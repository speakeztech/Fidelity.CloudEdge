#!/bin/bash
# scaffold-management-project.sh — Create a new management project from template
#
# Usage:
#   ./scaffold-management-project.sh <service-key>
#
# Creates:
#   src/Management/CloudEdge.Management.{Name}/CloudEdge.Management.{Name}.fsproj
# And adds the project to the solution file.

source "$(dirname "${BASH_SOURCE[0]}")/lib.sh"

# ─── Arguments ─────────────────────────────────────────────────────

SERVICE_KEY="${1:-}"

if [[ -z "$SERVICE_KEY" ]]; then
    print_error "Service key is required."
    echo "Usage: $0 <service-key>"
    echo ""
    echo "Available services:"
    list_services | sed 's/^/  /'
    exit 1
fi

SERVICE_NAME=$(get_service_name "$SERVICE_KEY")
NAMESPACE=$(get_namespace "$SERVICE_KEY")

if [[ -z "$SERVICE_NAME" ]]; then
    print_error "Unknown service: $SERVICE_KEY"
    exit 1
fi

if [[ -z "$NAMESPACE" ]]; then
    NAMESPACE="Fidelity.CloudEdge.Management.${SERVICE_NAME}"
fi

# ─── Paths ─────────────────────────────────────────────────────────

PROJECT_NAME="CloudEdge.Management.${SERVICE_NAME}"
PROJECT_DIR="$SRC_DIR/Management/$PROJECT_NAME"
FSPROJ_FILE="$PROJECT_DIR/${PROJECT_NAME}.fsproj"
SLN_FILE="$PROJECT_ROOT/Fidelity.CloudEdge.sln"

# ─── Check if already exists ──────────────────────────────────────

if [[ -f "$FSPROJ_FILE" ]]; then
    print_info "Project already exists: $PROJECT_NAME"
    exit 0
fi

# ─── Create project directory ─────────────────────────────────────

mkdir -p "$PROJECT_DIR"

# ─── Generate .fsproj ─────────────────────────────────────────────

cat > "$FSPROJ_FILE" << EOF
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <LangVersion>latest</LangVersion>
    <AssemblyName>${NAMESPACE}</AssemblyName>
    <RootNamespace>${NAMESPACE}</RootNamespace>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="StringEnum.fs" />
    <Compile Include="OpenApiHttp.fs" />
    <Compile Include="Types.fs" />
    <Compile Include="Client.fs" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="FSharp.SystemTextJson" Version="1.3.13" />
  </ItemGroup>
</Project>
EOF

print_success "Created $FSPROJ_FILE"

# ─── Add to solution ─────────────────────────────────────────────

if [[ -f "$SLN_FILE" ]]; then
    # Check if already in solution
    if grep -q "$PROJECT_NAME" "$SLN_FILE" 2>/dev/null; then
        print_info "Project already in solution"
    else
        RELATIVE_PATH="src/Management/${PROJECT_NAME}/${PROJECT_NAME}.fsproj"
        if dotnet sln "$SLN_FILE" add "$PROJECT_ROOT/$RELATIVE_PATH" 2>&1; then
            print_success "Added to Fidelity.CloudEdge.sln"
        else
            print_warn "Could not add to solution (add manually)"
        fi
    fi
else
    print_warn "Solution file not found: $SLN_FILE"
fi
