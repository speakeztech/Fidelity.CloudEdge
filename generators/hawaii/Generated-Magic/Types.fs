namespace rec Fidelity.CloudEdge.Management.Magic.Types

///Identifier.
type dosidentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type dosmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of dosmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): dosmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type dosmessages = list<dosmessagesArrayItem>
///UUID.
type dosuuid = string
///AS number associated with the node object.
type ``magic-transitasn`` = string

///type of check to perform
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-transitchecktype`` =
    | [<CompiledName "icmp">] Icmp
    member this.Format() =
        match this with
        | Icmp -> "icmp"

///Source colo city.
type ``magic-transitcolocity`` = string
///Source colo name.
type ``magic-transitcoloname`` = string
///If no source colo names specified, all colos will be used. China colos are unavailable for traceroutes.
type ``magic-transitcolos`` = list<string>

///Errors resulting from collecting traceroute from colo to target.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-transiterror`` =
    | [<CompiledName "">] EmptyString
    | [<CompiledName "Could not gather traceroute data: Code 1">] ``CouldNotGatherTracerouteData:CodeNumeric_1``
    | [<CompiledName "Could not gather traceroute data: Code 2">] ``CouldNotGatherTracerouteData:CodeNumeric_2``
    | [<CompiledName "Could not gather traceroute data: Code 3">] ``CouldNotGatherTracerouteData:CodeNumeric_3``
    | [<CompiledName "Could not gather traceroute data: Code 4">] ``CouldNotGatherTracerouteData:CodeNumeric_4``
    member this.Format() =
        match this with
        | EmptyString -> ""
        | ``CouldNotGatherTracerouteData:CodeNumeric_1`` -> "Could not gather traceroute data: Code 1"
        | ``CouldNotGatherTracerouteData:CodeNumeric_2`` -> "Could not gather traceroute data: Code 2"
        | ``CouldNotGatherTracerouteData:CodeNumeric_3`` -> "Could not gather traceroute data: Code 3"
        | ``CouldNotGatherTracerouteData:CodeNumeric_4`` -> "Could not gather traceroute data: Code 4"

///Identifier
type ``magic-transitidentifier`` = string
///IP address of the node.
type ``magic-transitip`` = string
///Field appears if there is an additional annotation printed when the probe returns. Field also appears when running a GRE+ICMP traceroute to denote which traceroute a node comes from.
type ``magic-transitlabels`` = list<string>
type ``magic-transitmaxrttms`` = float
type ``magic-transitmaxttl`` = int
type ``magic-transitmeanrttms`` = float

type ``magic-transitmessagesArrayItemSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitmessagesArrayItemSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitmessagesArrayItemSource`` = { pointer = None }

type ``magic-transitmessagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitmessagesArrayItemSource``> }
    ///Creates an instance of magic-transitmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitmessagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitmessages`` = list<``magic-transitmessagesArrayItem``>
type ``magic-transitminrttms`` = float
///Host name of the address, this may be the same as the IP address.
type ``magic-transitname`` = string
type ``magic-transitpacketcount`` = int

///Type of packet sent.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-transitpackettype`` =
    | [<CompiledName "icmp">] Icmp
    | [<CompiledName "tcp">] Tcp
    | [<CompiledName "udp">] Udp
    | [<CompiledName "gre">] Gre
    | [<CompiledName "gre+icmp">] ``Gre+icmp``
    member this.Format() =
        match this with
        | Icmp -> "icmp"
        | Tcp -> "tcp"
        | Udp -> "udp"
        | Gre -> "gre"
        | ``Gre+icmp`` -> "gre+icmp"

type ``magic-transitpacketslost`` = int
type ``magic-transitpacketsperttl`` = int
type ``magic-transitpacketssent`` = int
type ``magic-transitpacketsttl`` = int
type ``magic-transitport`` = int
type ``magic-transitstddevrttms`` = float
///The target hostname, IPv6, or IPv6 address.
type ``magic-transittarget`` = string
type ``magic-transittargets`` = list<string>
type ``magic-transittraceroutetimems`` = int
///UUID.
type ``magic-transituuid`` = string
type ``magic-transitwaittime`` = int
type ``magic-visibility-mnmaccountidentifier`` = string

type ``magic-visibility-mnmmessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmessagesArrayItem`` =
        { code = code; message = message }

type ``magic-visibility-mnmmessages`` = list<``magic-visibility-mnmmessagesArrayItem``>
type ``magic-visibility-mnmmnmconfigdefaultsampling`` = float
///The account name.
type ``magic-visibility-mnmmnmconfigname`` = string
///IPv4 CIDR of the router sourcing flow data. Only /32 addresses are currently supported.
type ``magic-visibility-mnmmnmconfigrouterip`` = string
type ``magic-visibility-mnmmnmconfigrouterips`` = list<``magic-visibility-mnm_mnm_config_router_ip``>
type ``magic-visibility-mnmmnmconfigwarpdevices`` = list<``magic-visibility-mnm_mnm_config_warp_device``>
type ``magic-visibility-mnmmnmruleautomaticadvertisement`` = bool
type ``magic-visibility-mnmmnmrulebandwidththreshold`` = float

///The amount of time that the rule threshold must be exceeded to send an alert notification. The final value must be equivalent to one of the following 8 values ["1m","5m","10m","15m","20m","30m","45m","60m"].
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-mnmmnmruleduration`` =
    | [<CompiledName "1m">] M
    member this.Format() =
        match this with
        | M -> "1m"

///The IP prefixes that are monitored for this rule. Must be a CIDR range like 203.0.113.0/24. Max 5000 different CIDR ranges.
type ``magic-visibility-mnmmnmruleipprefix`` = string
type ``magic-visibility-mnmmnmruleipprefixes`` = list<``magic-visibility-mnm_mnm_rule_ip_prefix``>
///The name of the rule. Must be unique. Supports characters A-Z, a-z, 0-9, underscore (_), dash (-), period (.), and tilde (~). You can’t have a space in the rule name. Max 256 characters.
type ``magic-visibility-mnmmnmrulename`` = string
type ``magic-visibility-mnmmnmrulepacketthreshold`` = float

///Prefix match type to be applied for a prefix auto advertisement when using an advanced_ddos rule.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-mnmmnmruleprefixmatch`` =
    | [<CompiledName "exact">] Exact
    | [<CompiledName "subnet">] Subnet
    | [<CompiledName "supernet">] Supernet
    member this.Format() =
        match this with
        | Exact -> "exact"
        | Subnet -> "subnet"
        | Supernet -> "supernet"

///MNM rule type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-mnmmnmruletype`` =
    | [<CompiledName "threshold">] Threshold
    | [<CompiledName "zscore">] Zscore
    | [<CompiledName "advanced_ddos">] Advanced_ddos
    member this.Format() =
        match this with
        | Threshold -> "threshold"
        | Zscore -> "zscore"
        | Advanced_ddos -> "advanced_ddos"

///Level of sensitivity set for zscore rules.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-mnmmnmrulezscoresensitivity`` =
    | [<CompiledName "low">] Low
    | [<CompiledName "medium">] Medium
    | [<CompiledName "high">] High
    member this.Format() =
        match this with
        | Low -> "low"
        | Medium -> "medium"
        | High -> "high"

///Target of the zscore rule analysis.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-mnmmnmrulezscoretarget`` =
    | [<CompiledName "bits">] Bits
    | [<CompiledName "packets">] Packets
    member this.Format() =
        match this with
        | Bits -> "bits"
        | Packets -> "packets"

///Authentication token to be used for VPC Flows export authentication.
type ``magic-visibility-mnmmnmvpcflowstoken`` = string
///The id of the rule. Must be unique.
type ``magic-visibility-mnmruleidentifier`` = string
///Identifier.
type ``magic-visibility-pcapsidentifier`` = string

type ``magic-visibility-pcapsmessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsmessagesArrayItem`` =
        { code = code; message = message }

type ``magic-visibility-pcapsmessages`` = list<``magic-visibility-pcapsmessagesArrayItem``>
type ``magic-visibility-pcapspcapsbytelimit`` = float
///The name of the data center used for the packet capture. This can be a specific colo (ord02) or a multi-colo name (ORD). This field only applies to `full` packet captures.
type ``magic-visibility-pcapspcapscoloname`` = string
///The full URI for the bucket. This field only applies to `full` packet captures.
type ``magic-visibility-pcapspcapsdestinationconf`` = string
///An error message that describes why the packet capture failed. This field only applies to `full` packet captures.
type ``magic-visibility-pcapspcapserrormessage`` = string
///The ID for the packet capture.
type ``magic-visibility-pcapspcapsid`` = string
///The RFC 3339 offset timestamp from which to query backwards for packets. Must be within the last 24h. When this field is empty, defaults to time of request.
type ``magic-visibility-pcapspcapsoffsettime`` = System.DateTimeOffset
///The ownership challenge filename stored in the bucket.
type ``magic-visibility-pcapspcapsownershipchallenge`` = string
type ``magic-visibility-pcapspcapspacketlimit`` = float
type ``magic-visibility-pcapspcapspacketscaptured`` = int

///The status of the packet capture request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-pcapspcapsstatus`` =
    | [<CompiledName "unknown">] Unknown
    | [<CompiledName "success">] Success
    | [<CompiledName "pending">] Pending
    | [<CompiledName "running">] Running
    | [<CompiledName "conversion_pending">] Conversion_pending
    | [<CompiledName "conversion_running">] Conversion_running
    | [<CompiledName "complete">] Complete
    | [<CompiledName "failed">] Failed
    member this.Format() =
        match this with
        | Unknown -> "unknown"
        | Success -> "success"
        | Pending -> "pending"
        | Running -> "running"
        | Conversion_pending -> "conversion_pending"
        | Conversion_running -> "conversion_running"
        | Complete -> "complete"
        | Failed -> "failed"

///The RFC 3339 timestamp when stopping the packet capture was requested. This field only applies to `full` packet captures.
type ``magic-visibility-pcapspcapsstoprequested`` = System.DateTimeOffset
///The RFC 3339 timestamp when the packet capture was created.
type ``magic-visibility-pcapspcapssubmitted`` = string

///The system used to collect packet captures.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-pcapspcapssystem`` =
    | [<CompiledName "magic-transit">] MagicTransit
    member this.Format() =
        match this with
        | MagicTransit -> "magic-transit"

type ``magic-visibility-pcapspcapstimelimitfull`` = float
type ``magic-visibility-pcapspcapstimelimitsampled`` = float

///The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``magic-visibility-pcapspcapstype`` =
    | [<CompiledName "simple">] Simple
    | [<CompiledName "full">] Full
    member this.Format() =
        match this with
        | Simple -> "simple"
        | Full -> "full"

///Magic account app ID.
type magicaccountappid = string
///A valid port range value.
type ``magicacl-port-range`` = string
type magicallownullcipher = bool
type magicappbreakout = bool
type magicappbreakoutpreferredwans = list<magic_identifier>
///FQDNs to associate with traffic decisions.
type magicapphostnames = list<string>
///Display name for the app.
type magicappname = string
type magicapppriority = int
type magicappsourcesubnets = list<magic_cidr>
type magicappsubnets = list<magic_cidr>
///Category of the app.
type magicapptype = string
type magicautomaticreturnrouting = bool
type magicbondid = int
///A valid CIDR notation representing an IP range.
type magiccidr = string
///The IP address assigned to the Cloudflare side of the GRE tunnel.
type magiccloudflaregreendpoint = string
///The IP address assigned to the Cloudflare side of the IPsec tunnel.
type magiccloudflareipsecendpoint = string
///Scope colo name.
type magiccoloname = string
type magiccolonames = list<magic_colo_name>
///Scope colo region.
type magiccoloregion = string
type magiccoloregions = list<magic_colo_region>
///An optional description forthe IPsec tunnel.
type ``magiccomponents-schemas-description`` = string
///The name of the interconnect. The name cannot share a name with other tunnels.
type ``magiccomponents-schemas-name`` = string
///Magic Connector identifier tag.
type ``magicconnector-id`` = string
///When the route was created.
type magiccreatedon = System.DateTimeOffset
///The IP address assigned to the customer side of the GRE tunnel.
type magiccustomergreendpoint = string
///The IP address assigned to the customer side of the IPsec tunnel. Not required, but must be set for proactive traceroutes to work.
type magiccustomeripsecendpoint = string
///An optional human provided description of the static route.
type magicdescription = string
type magicforwardlocally = bool
///The name of the tunnel. The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
type magicgretunnelname = string
///Identifier
type magicidentifier = string
///An optional description of the interconnect.
type ``magicinterconnectcomponents-schemas-description`` = string
///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
type magicinterfaceaddress = string
///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
type magicinterfaceaddress6 = string
///A valid IPv4 address.
type ``magicip-address`` = string
///The name of the IPsec tunnel. The name cannot share a name with other tunnels.
type magicipsectunnelname = string
///Managed app ID.
type magicmanagedappid = string

type magicmessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of magicmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmessagesArrayItem = { code = code; message = message }

type magicmessages = list<magicmessagesArrayItem>
///When the route was last modified.
type magicmodifiedon = System.DateTimeOffset
type magicmtu = int
///The next-hop IP Address for the static route.
type magicnexthop = string
type magicport = int
///IP Prefix in Classless Inter-Domain Routing format.
type magicprefix = string
type magicpriority = int
///A randomly generated or provided string for use in the IPsec tunnel.
type magicpsk = string
type magicreplayprotection = bool
///The date and time the tunnel was created.
type ``magicschemas-createdon`` = System.DateTimeOffset
///An optional description of the GRE tunnel.
type ``magicschemas-description`` = string
///Identifier
type ``magicschemas-identifier`` = string
///The date and time the tunnel was last modified.
type ``magicschemas-modifiedon`` = System.DateTimeOffset
type ``magicschemas-mtu`` = int
///Magic Connector identifier tag. Used when high availability mode is on.
type ``magicsecondary-connector-id`` = string
///The name of the site.
type ``magicsite-name`` = string
type magicttl = int
type magicunidirectional = bool
type magicvlantag = int
type magicweight = int
type mcnaccountid = string
type mcncatalogsyncdestinationid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcncatalogsyncdestinationtype =
    | [<CompiledName "NONE">] NONE
    | [<CompiledName "ZERO_TRUST_LIST">] ZERO_TRUST_LIST
    member this.Format() =
        match this with
        | NONE -> "NONE"
        | ZERO_TRUST_LIST -> "ZERO_TRUST_LIST"

type mcncatalogsyncid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcncatalogsyncupdatemode =
    | [<CompiledName "AUTO">] AUTO
    | [<CompiledName "MANUAL">] MANUAL
    member this.Format() =
        match this with
        | AUTO -> "AUTO"
        | MANUAL -> "MANUAL"

///An IP address prefix in CIDR format.
type mcncidrprefix = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcncloudtype =
    | [<CompiledName "AWS">] AWS
    | [<CompiledName "AZURE">] AZURE
    | [<CompiledName "GOOGLE">] GOOGLE
    | [<CompiledName "CLOUDFLARE">] CLOUDFLARE
    member this.Format() =
        match this with
        | AWS -> "AWS"
        | AZURE -> "AZURE"
        | GOOGLE -> "GOOGLE"
        | CLOUDFLARE -> "CLOUDFLARE"

type mcnconduitrouteid = System.Guid
type mcnconduittunnelid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnonrampcloudtype =
    | [<CompiledName "AWS">] AWS
    | [<CompiledName "AZURE">] AZURE
    | [<CompiledName "GOOGLE">] GOOGLE
    member this.Format() =
        match this with
        | AWS -> "AWS"
        | AZURE -> "AZURE"
        | GOOGLE -> "GOOGLE"

type mcnonrampid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnonramplifecyclestate =
    | [<CompiledName "OnrampNeedsApply">] OnrampNeedsApply
    | [<CompiledName "OnrampPendingPlan">] OnrampPendingPlan
    | [<CompiledName "OnrampPlanning">] OnrampPlanning
    | [<CompiledName "OnrampPlanFailed">] OnrampPlanFailed
    | [<CompiledName "OnrampPendingApproval">] OnrampPendingApproval
    | [<CompiledName "OnrampPendingApply">] OnrampPendingApply
    | [<CompiledName "OnrampApplying">] OnrampApplying
    | [<CompiledName "OnrampApplyFailed">] OnrampApplyFailed
    | [<CompiledName "OnrampActive">] OnrampActive
    | [<CompiledName "OnrampPendingDestroy">] OnrampPendingDestroy
    | [<CompiledName "OnrampDestroying">] OnrampDestroying
    | [<CompiledName "OnrampDestroyFailed">] OnrampDestroyFailed
    member this.Format() =
        match this with
        | OnrampNeedsApply -> "OnrampNeedsApply"
        | OnrampPendingPlan -> "OnrampPendingPlan"
        | OnrampPlanning -> "OnrampPlanning"
        | OnrampPlanFailed -> "OnrampPlanFailed"
        | OnrampPendingApproval -> "OnrampPendingApproval"
        | OnrampPendingApply -> "OnrampPendingApply"
        | OnrampApplying -> "OnrampApplying"
        | OnrampApplyFailed -> "OnrampApplyFailed"
        | OnrampActive -> "OnrampActive"
        | OnrampPendingDestroy -> "OnrampPendingDestroy"
        | OnrampDestroying -> "OnrampDestroying"
        | OnrampDestroyFailed -> "OnrampDestroyFailed"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnonramptype =
    | [<CompiledName "OnrampTypeSingle">] OnrampTypeSingle
    | [<CompiledName "OnrampTypeHub">] OnrampTypeHub
    member this.Format() =
        match this with
        | OnrampTypeSingle -> "OnrampTypeSingle"
        | OnrampTypeHub -> "OnrampTypeHub"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnplannedaction =
    | [<CompiledName "no_op">] No_op
    | [<CompiledName "create">] Create
    | [<CompiledName "update">] Update
    | [<CompiledName "replace">] Replace
    | [<CompiledName "destroy">] Destroy
    member this.Format() =
        match this with
        | No_op -> "no_op"
        | Create -> "create"
        | Update -> "update"
        | Replace -> "replace"
        | Destroy -> "destroy"

type mcnplatformclientid = System.Guid
type mcnpolicyresult = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnproviderdiscoverystatus =
    | [<CompiledName "UNSPECIFIED">] UNSPECIFIED
    | [<CompiledName "PENDING">] PENDING
    | [<CompiledName "DISCOVERING">] DISCOVERING
    | [<CompiledName "FAILED">] FAILED
    | [<CompiledName "SUCCEEDED">] SUCCEEDED
    member this.Format() =
        match this with
        | UNSPECIFIED -> "UNSPECIFIED"
        | PENDING -> "PENDING"
        | DISCOVERING -> "DISCOVERING"
        | FAILED -> "FAILED"
        | SUCCEEDED -> "SUCCEEDED"

type mcnproviderid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnproviderlifecyclestate =
    | [<CompiledName "ACTIVE">] ACTIVE
    | [<CompiledName "PENDING_SETUP">] PENDING_SETUP
    | [<CompiledName "RETIRED">] RETIRED
    member this.Format() =
        match this with
        | ACTIVE -> "ACTIVE"
        | PENDING_SETUP -> "PENDING_SETUP"
        | RETIRED -> "RETIRED"

type mcnresourceid = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mcnresourcetype =
    | [<CompiledName "aws_customer_gateway">] Aws_customer_gateway
    | [<CompiledName "aws_egress_only_internet_gateway">] Aws_egress_only_internet_gateway
    | [<CompiledName "aws_internet_gateway">] Aws_internet_gateway
    | [<CompiledName "aws_instance">] Aws_instance
    | [<CompiledName "aws_network_interface">] Aws_network_interface
    | [<CompiledName "aws_route">] Aws_route
    | [<CompiledName "aws_route_table">] Aws_route_table
    | [<CompiledName "aws_route_table_association">] Aws_route_table_association
    | [<CompiledName "aws_subnet">] Aws_subnet
    | [<CompiledName "aws_vpc">] Aws_vpc
    | [<CompiledName "aws_vpc_ipv4_cidr_block_association">] Aws_vpc_ipv4_cidr_block_association
    | [<CompiledName "aws_vpn_connection">] Aws_vpn_connection
    | [<CompiledName "aws_vpn_connection_route">] Aws_vpn_connection_route
    | [<CompiledName "aws_vpn_gateway">] Aws_vpn_gateway
    | [<CompiledName "aws_security_group">] Aws_security_group
    | [<CompiledName "aws_vpc_security_group_ingress_rule">] Aws_vpc_security_group_ingress_rule
    | [<CompiledName "aws_vpc_security_group_egress_rule">] Aws_vpc_security_group_egress_rule
    | [<CompiledName "aws_ec2_managed_prefix_list">] Aws_ec2_managed_prefix_list
    | [<CompiledName "aws_ec2_transit_gateway">] Aws_ec2_transit_gateway
    | [<CompiledName "aws_ec2_transit_gateway_prefix_list_reference">] Aws_ec2_transit_gateway_prefix_list_reference
    | [<CompiledName "aws_ec2_transit_gateway_vpc_attachment">] Aws_ec2_transit_gateway_vpc_attachment
    | [<CompiledName "azurerm_application_security_group">] Azurerm_application_security_group
    | [<CompiledName "azurerm_lb">] Azurerm_lb
    | [<CompiledName "azurerm_lb_backend_address_pool">] Azurerm_lb_backend_address_pool
    | [<CompiledName "azurerm_lb_nat_pool">] Azurerm_lb_nat_pool
    | [<CompiledName "azurerm_lb_nat_rule">] Azurerm_lb_nat_rule
    | [<CompiledName "azurerm_lb_rule">] Azurerm_lb_rule
    | [<CompiledName "azurerm_local_network_gateway">] Azurerm_local_network_gateway
    | [<CompiledName "azurerm_network_interface">] Azurerm_network_interface
    | [<CompiledName "azurerm_network_interface_application_security_group_association">] Azurerm_network_interface_application_security_group_association
    | [<CompiledName "azurerm_network_interface_backend_address_pool_association">] Azurerm_network_interface_backend_address_pool_association
    | [<CompiledName "azurerm_network_interface_security_group_association">] Azurerm_network_interface_security_group_association
    | [<CompiledName "azurerm_network_security_group">] Azurerm_network_security_group
    | [<CompiledName "azurerm_public_ip">] Azurerm_public_ip
    | [<CompiledName "azurerm_route">] Azurerm_route
    | [<CompiledName "azurerm_route_table">] Azurerm_route_table
    | [<CompiledName "azurerm_subnet">] Azurerm_subnet
    | [<CompiledName "azurerm_subnet_route_table_association">] Azurerm_subnet_route_table_association
    | [<CompiledName "azurerm_virtual_machine">] Azurerm_virtual_machine
    | [<CompiledName "azurerm_virtual_network_gateway_connection">] Azurerm_virtual_network_gateway_connection
    | [<CompiledName "azurerm_virtual_network">] Azurerm_virtual_network
    | [<CompiledName "azurerm_virtual_network_gateway">] Azurerm_virtual_network_gateway
    | [<CompiledName "google_compute_network">] Google_compute_network
    | [<CompiledName "google_compute_subnetwork">] Google_compute_subnetwork
    | [<CompiledName "google_compute_vpn_gateway">] Google_compute_vpn_gateway
    | [<CompiledName "google_compute_vpn_tunnel">] Google_compute_vpn_tunnel
    | [<CompiledName "google_compute_route">] Google_compute_route
    | [<CompiledName "google_compute_address">] Google_compute_address
    | [<CompiledName "google_compute_global_address">] Google_compute_global_address
    | [<CompiledName "google_compute_router">] Google_compute_router
    | [<CompiledName "google_compute_interconnect_attachment">] Google_compute_interconnect_attachment
    | [<CompiledName "google_compute_ha_vpn_gateway">] Google_compute_ha_vpn_gateway
    | [<CompiledName "google_compute_forwarding_rule">] Google_compute_forwarding_rule
    | [<CompiledName "google_compute_network_firewall_policy">] Google_compute_network_firewall_policy
    | [<CompiledName "google_compute_network_firewall_policy_rule">] Google_compute_network_firewall_policy_rule
    | [<CompiledName "cloudflare_static_route">] Cloudflare_static_route
    | [<CompiledName "cloudflare_ipsec_tunnel">] Cloudflare_ipsec_tunnel
    member this.Format() =
        match this with
        | Aws_customer_gateway -> "aws_customer_gateway"
        | Aws_egress_only_internet_gateway -> "aws_egress_only_internet_gateway"
        | Aws_internet_gateway -> "aws_internet_gateway"
        | Aws_instance -> "aws_instance"
        | Aws_network_interface -> "aws_network_interface"
        | Aws_route -> "aws_route"
        | Aws_route_table -> "aws_route_table"
        | Aws_route_table_association -> "aws_route_table_association"
        | Aws_subnet -> "aws_subnet"
        | Aws_vpc -> "aws_vpc"
        | Aws_vpc_ipv4_cidr_block_association -> "aws_vpc_ipv4_cidr_block_association"
        | Aws_vpn_connection -> "aws_vpn_connection"
        | Aws_vpn_connection_route -> "aws_vpn_connection_route"
        | Aws_vpn_gateway -> "aws_vpn_gateway"
        | Aws_security_group -> "aws_security_group"
        | Aws_vpc_security_group_ingress_rule -> "aws_vpc_security_group_ingress_rule"
        | Aws_vpc_security_group_egress_rule -> "aws_vpc_security_group_egress_rule"
        | Aws_ec2_managed_prefix_list -> "aws_ec2_managed_prefix_list"
        | Aws_ec2_transit_gateway -> "aws_ec2_transit_gateway"
        | Aws_ec2_transit_gateway_prefix_list_reference -> "aws_ec2_transit_gateway_prefix_list_reference"
        | Aws_ec2_transit_gateway_vpc_attachment -> "aws_ec2_transit_gateway_vpc_attachment"
        | Azurerm_application_security_group -> "azurerm_application_security_group"
        | Azurerm_lb -> "azurerm_lb"
        | Azurerm_lb_backend_address_pool -> "azurerm_lb_backend_address_pool"
        | Azurerm_lb_nat_pool -> "azurerm_lb_nat_pool"
        | Azurerm_lb_nat_rule -> "azurerm_lb_nat_rule"
        | Azurerm_lb_rule -> "azurerm_lb_rule"
        | Azurerm_local_network_gateway -> "azurerm_local_network_gateway"
        | Azurerm_network_interface -> "azurerm_network_interface"
        | Azurerm_network_interface_application_security_group_association ->
            "azurerm_network_interface_application_security_group_association"
        | Azurerm_network_interface_backend_address_pool_association ->
            "azurerm_network_interface_backend_address_pool_association"
        | Azurerm_network_interface_security_group_association -> "azurerm_network_interface_security_group_association"
        | Azurerm_network_security_group -> "azurerm_network_security_group"
        | Azurerm_public_ip -> "azurerm_public_ip"
        | Azurerm_route -> "azurerm_route"
        | Azurerm_route_table -> "azurerm_route_table"
        | Azurerm_subnet -> "azurerm_subnet"
        | Azurerm_subnet_route_table_association -> "azurerm_subnet_route_table_association"
        | Azurerm_virtual_machine -> "azurerm_virtual_machine"
        | Azurerm_virtual_network_gateway_connection -> "azurerm_virtual_network_gateway_connection"
        | Azurerm_virtual_network -> "azurerm_virtual_network"
        | Azurerm_virtual_network_gateway -> "azurerm_virtual_network_gateway"
        | Google_compute_network -> "google_compute_network"
        | Google_compute_subnetwork -> "google_compute_subnetwork"
        | Google_compute_vpn_gateway -> "google_compute_vpn_gateway"
        | Google_compute_vpn_tunnel -> "google_compute_vpn_tunnel"
        | Google_compute_route -> "google_compute_route"
        | Google_compute_address -> "google_compute_address"
        | Google_compute_global_address -> "google_compute_global_address"
        | Google_compute_router -> "google_compute_router"
        | Google_compute_interconnect_attachment -> "google_compute_interconnect_attachment"
        | Google_compute_ha_vpn_gateway -> "google_compute_ha_vpn_gateway"
        | Google_compute_forwarding_rule -> "google_compute_forwarding_rule"
        | Google_compute_network_firewall_policy -> "google_compute_network_firewall_policy"
        | Google_compute_network_firewall_policy_rule -> "google_compute_network_firewall_policy_rule"
        | Cloudflare_static_route -> "cloudflare_static_route"
        | Cloudflare_ipsec_tunnel -> "cloudflare_ipsec_tunnel"

type mcnresourcescatalogpolicypreview = string
///Account identifier
type mconnaccountid = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type mconndayofweek =
    | [<CompiledName "Sunday">] Sunday
    | [<CompiledName "Monday">] Monday
    | [<CompiledName "Tuesday">] Tuesday
    | [<CompiledName "Wednesday">] Wednesday
    | [<CompiledName "Thursday">] Thursday
    | [<CompiledName "Friday">] Friday
    | [<CompiledName "Saturday">] Saturday
    member this.Format() =
        match this with
        | Sunday -> "Sunday"
        | Monday -> "Monday"
        | Tuesday -> "Tuesday"
        | Wednesday -> "Wednesday"
        | Thursday -> "Thursday"
        | Friday -> "Friday"
        | Saturday -> "Saturday"

type mconnembargodate = string
type mconnuuid = string

type dosDnsProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The creation timestamp of the DNS Protection rule.
      created_on: System.DateTimeOffset
      ///The unique ID of the DNS Protection rule.
      id: string
      ///The mode for DNS Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The last modification timestamp of the DNS Protection rule.
      modified_on: System.DateTimeOffset
      ///The name of the DNS Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The profile sensitivity. Recommended setting is 'low'. Must be one of 'low', 'medium', 'high', or 'very_high'.
      profile_sensitivity: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the DNS Protection rule. Must be one of 'global', 'region', or 'datacenter'.
      scope: string }
    ///Creates an instance of dosDnsProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string,
                          created_on: System.DateTimeOffset,
                          id: string,
                          mode: string,
                          modified_on: System.DateTimeOffset,
                          name: string,
                          profile_sensitivity: string,
                          rate_sensitivity: string,
                          scope: string): dosDnsProtectionRule =
        { burst_sensitivity = burst_sensitivity
          created_on = created_on
          id = id
          mode = mode
          modified_on = modified_on
          name = name
          profile_sensitivity = profile_sensitivity
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosDnsProtectionRuleUpdate =
    { ///The new burst sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: Option<string>
      ///The new mode for DNS Protection. Optional. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: Option<string>
      ///The new profile sensitivity. Optional. Recommended setting is 'low'. Must be one of 'low', 'medium', 'high', or 'very_high'.
      profile_sensitivity: Option<string>
      ///The new rate sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: Option<string> }
    ///Creates an instance of dosDnsProtectionRuleUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosDnsProtectionRuleUpdate =
        { burst_sensitivity = None
          mode = None
          profile_sensitivity = None
          rate_sensitivity = None }

type dosExpressionFilter =
    { ///The creation timestamp of the expression filter.
      created_on: System.DateTimeOffset
      ///The filter expression.
      expression: string
      ///The unique ID of the expression filter.
      id: string
      ///The filter's mode. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The last modification timestamp of the expression filter.
      modified_on: System.DateTimeOffset }
    ///Creates an instance of dosExpressionFilter with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_on: System.DateTimeOffset,
                          expression: string,
                          id: string,
                          mode: string,
                          modified_on: System.DateTimeOffset): dosExpressionFilter =
        { created_on = created_on
          expression = expression
          id = id
          mode = mode
          modified_on = modified_on }

type dosExpressionFilterUpdate =
    { ///The new filter expression. Optional.
      expression: Option<string>
      ///The new mode for the filter. Optional. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: Option<string> }
    ///Creates an instance of dosExpressionFilterUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosExpressionFilterUpdate = { expression = None; mode = None }

type dosInfraPrefix =
    { ///An optional comment describing the allowlist prefix.
      comment: string
      ///The creation timestamp of the allowlist prefix.
      created_on: System.DateTimeOffset
      ///Whether to enable the allowlist prefix into effect. Defaults to false.
      enabled: bool
      ///The unique ID of the allowlist prefix.
      id: string
      ///The last modification timestamp of the allowlist prefix.
      modified_on: System.DateTimeOffset
      ///The allowlist prefix in CIDR format.
      prefix: string }
    ///Creates an instance of dosInfraPrefix with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string,
                          created_on: System.DateTimeOffset,
                          enabled: bool,
                          id: string,
                          modified_on: System.DateTimeOffset,
                          prefix: string): dosInfraPrefix =
        { comment = comment
          created_on = created_on
          enabled = enabled
          id = id
          modified_on = modified_on
          prefix = prefix }

type dosInfraPrefixUpdate =
    { ///A comment describing the allowlist prefix. Optional.
      comment: Option<string>
      ///Whether to enable the allowlist prefix into effect. Optional.
      enabled: Option<bool> }
    ///Creates an instance of dosInfraPrefixUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosInfraPrefixUpdate = { comment = None; enabled = None }

type dosNewDnsProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The mode for DNS Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The name of the DNS Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The profile sensitivity. Recommended setting is 'low'. Must be one of 'low', 'medium', 'high', or 'very_high'.
      profile_sensitivity: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the DNS Protection rule. Must be one of 'global', 'region', or 'datacenter'.
      scope: string }
    ///Creates an instance of dosNewDnsProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string,
                          mode: string,
                          name: string,
                          profile_sensitivity: string,
                          rate_sensitivity: string,
                          scope: string): dosNewDnsProtectionRule =
        { burst_sensitivity = burst_sensitivity
          mode = mode
          name = name
          profile_sensitivity = profile_sensitivity
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosNewExpressionFilter =
    { ///The filter expression.
      expression: string
      ///The filter's mode. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string }
    ///Creates an instance of dosNewExpressionFilter with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expression: string, mode: string): dosNewExpressionFilter =
        { expression = expression; mode = mode }

type dosNewInfraPrefix =
    { ///An comment describing the allowlist prefix.
      comment: string
      ///Whether to enable the allowlist prefix into effect.
      enabled: bool
      ///The allowlist prefix to add in CIDR format.
      prefix: string }
    ///Creates an instance of dosNewInfraPrefix with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string, enabled: bool, prefix: string): dosNewInfraPrefix =
        { comment = comment
          enabled = enabled
          prefix = prefix }

type dosNewPrefix =
    { ///A comment describing the prefix.
      comment: string
      ///Whether to exclude the prefix from protection.
      excluded: bool
      ///The prefix to add in CIDR format.
      prefix: string }
    ///Creates an instance of dosNewPrefix with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string, excluded: bool, prefix: string): dosNewPrefix =
        { comment = comment
          excluded = excluded
          prefix = prefix }

type dosNewSynProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The type of mitigation. Must be one of 'challenge' or 'retransmit'. Optional. Defaults to 'challenge'.
      mitigation_type: Option<string>
      ///The mode for SYN Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The name of the SYN Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the SYN Protection rule. Must be one of 'global', 'region', or 'datacenter'.
      scope: string }
    ///Creates an instance of dosNewSynProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string, mode: string, name: string, rate_sensitivity: string, scope: string): dosNewSynProtectionRule =
        { burst_sensitivity = burst_sensitivity
          mitigation_type = None
          mode = mode
          name = name
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosNewTcpFlowProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The mode for the TCP Flow Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The name of the TCP Flow Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the TCP Flow Protection rule.
      scope: string }
    ///Creates an instance of dosNewTcpFlowProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string, mode: string, name: string, rate_sensitivity: string, scope: string): dosNewTcpFlowProtectionRule =
        { burst_sensitivity = burst_sensitivity
          mode = mode
          name = name
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosPrefix =
    { ///A comment describing the prefix.
      comment: string
      ///The creation timestamp of the prefix.
      created_on: System.DateTimeOffset
      ///Whether to exclude the prefix from protection.
      excluded: bool
      ///The unique ID of the prefix.
      id: string
      ///The last modification timestamp of the prefix.
      modified_on: System.DateTimeOffset
      ///The prefix in CIDR format.
      prefix: string }
    ///Creates an instance of dosPrefix with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string,
                          created_on: System.DateTimeOffset,
                          excluded: bool,
                          id: string,
                          modified_on: System.DateTimeOffset,
                          prefix: string): dosPrefix =
        { comment = comment
          created_on = created_on
          excluded = excluded
          id = id
          modified_on = modified_on
          prefix = prefix }

type dosPrefixUpdate =
    { ///A new comment for the prefix. Optional.
      comment: Option<string>
      ///Whether to exclude the prefix from protection. Optional.
      excluded: Option<bool> }
    ///Creates an instance of dosPrefixUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosPrefixUpdate = { comment = None; excluded = None }

type dosProtectionStatus =
    { enabled: bool }
    ///Creates an instance of dosProtectionStatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): dosProtectionStatus = { enabled = enabled }

type dosSynProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The creation timestamp of the SYN Protection rule.
      created_on: System.DateTimeOffset
      ///The unique ID of the SYN Protection rule.
      id: string
      ///The type of mitigation for SYN Protection. Must be one of 'challenge' or 'retransmit'.
      mitigation_type: string
      ///The mode for SYN Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The last modification timestamp of the SYN Protection rule.
      modified_on: System.DateTimeOffset
      ///The name of the SYN Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the SYN Protection rule. Must be one of 'global', 'region', or 'datacenter'.
      scope: string }
    ///Creates an instance of dosSynProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string,
                          created_on: System.DateTimeOffset,
                          id: string,
                          mitigation_type: string,
                          mode: string,
                          modified_on: System.DateTimeOffset,
                          name: string,
                          rate_sensitivity: string,
                          scope: string): dosSynProtectionRule =
        { burst_sensitivity = burst_sensitivity
          created_on = created_on
          id = id
          mitigation_type = mitigation_type
          mode = mode
          modified_on = modified_on
          name = name
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosSynProtectionRuleUpdate =
    { ///The new burst sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: Option<string>
      ///The new mitigation type. Optional. Must be one of 'challenge' or 'retransmit'.
      mitigation_type: Option<string>
      ///The new mode for SYN Protection. Optional. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: Option<string>
      ///The new rate sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: Option<string> }
    ///Creates an instance of dosSynProtectionRuleUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosSynProtectionRuleUpdate =
        { burst_sensitivity = None
          mitigation_type = None
          mode = None
          rate_sensitivity = None }

type dosTcpFlowProtectionRule =
    { ///The burst sensitivity. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: string
      ///The creation timestamp of the TCP Flow Protection rule.
      created_on: System.DateTimeOffset
      ///The unique ID of the TCP Flow Protection rule.
      id: string
      ///The mode for TCP Flow Protection. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: string
      ///The last modification timestamp of the TCP Flow Protection rule.
      modified_on: System.DateTimeOffset
      ///The name of the TCP Flow Protection rule. Value is relative to the 'scope' setting. For 'global' scope, name should be 'global'. For either the 'region' or 'datacenter' scope, name should be the actual name of the region or datacenter, e.g., 'wnam' or 'lax'.
      name: string
      ///The rate sensitivity. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: string
      ///The scope for the TCP Flow Protection rule. Must be one of 'global', 'region', or 'datacenter'.
      scope: string }
    ///Creates an instance of dosTcpFlowProtectionRule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (burst_sensitivity: string,
                          created_on: System.DateTimeOffset,
                          id: string,
                          mode: string,
                          modified_on: System.DateTimeOffset,
                          name: string,
                          rate_sensitivity: string,
                          scope: string): dosTcpFlowProtectionRule =
        { burst_sensitivity = burst_sensitivity
          created_on = created_on
          id = id
          mode = mode
          modified_on = modified_on
          name = name
          rate_sensitivity = rate_sensitivity
          scope = scope }

type dosTcpFlowProtectionRuleUpdate =
    { ///The new burst sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      burst_sensitivity: Option<string>
      ///The new mode for TCP Flow Protection. Optional. Must be one of 'enabled', 'disabled', 'monitoring'.
      mode: Option<string>
      ///The new rate sensitivity. Optional. Must be one of 'low', 'medium', 'high'.
      rate_sensitivity: Option<string> }
    ///Creates an instance of dosTcpFlowProtectionRuleUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): dosTcpFlowProtectionRuleUpdate =
        { burst_sensitivity = None
          mode = None
          rate_sensitivity = None }

type dosUpdateProtectionStatus =
    { ///Enables or disables protection.
      enabled: bool }
    ///Creates an instance of dosUpdateProtectionStatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool): dosUpdateProtectionStatus = { enabled = enabled }

type ErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ErrorsSource = { pointer = None }

type Errors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<ErrorsSource> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type MessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MessagesSource = { pointer = None }

type Messages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<MessagesSource> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dosapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of dosapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``dosapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosapi-response-commonErrorsSource`` = { pointer = None }

type ``dosapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosapi-response-commonErrorsSource``> }
    ///Creates an instance of dosapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosapi-response-commonMessagesSource`` = { pointer = None }

type ``dosapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosapi-response-commonMessagesSource``> }
    ///Creates an instance of dosapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosapi-response-common`` =
    { errors: list<``dosapi-response-commonErrors``>
      messages: list<``dosapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of dosapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``dosapi-response-commonErrors``>,
                          messages: list<``dosapi-response-commonMessages``>,
                          success: bool): ``dosapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``dosapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of dosapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``dosapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``dosdns-protection-rule-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosdns-protection-rule-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-list-responseErrorsSource`` = { pointer = None }

type ``dosdns-protection-rule-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosdns-protection-rule-list-responseErrorsSource``> }
    ///Creates an instance of dosdns-protection-rule-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosdns-protection-rule-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosdns-protection-rule-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosdns-protection-rule-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-list-responseMessagesSource`` = { pointer = None }

type ``dosdns-protection-rule-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosdns-protection-rule-list-responseMessagesSource``> }
    ///Creates an instance of dosdns-protection-rule-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosdns-protection-rule-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosdns-protection-rule-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dosdns-protection-rule-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dosdns-protection-rule-list-response`` =
    { errors: Option<list<``dosdns-protection-rule-list-responseErrors``>>
      messages: Option<list<``dosdns-protection-rule-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dosdns-protection-rule-list-responseResultinfo``>
      result: Option<list<dosDnsProtectionRule>> }
    ///Creates an instance of dosdns-protection-rule-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dosdns-protection-rule-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosdns-protection-rule-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-responseErrorsSource`` = { pointer = None }

type ``dosdns-protection-rule-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosdns-protection-rule-responseErrorsSource``> }
    ///Creates an instance of dosdns-protection-rule-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosdns-protection-rule-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosdns-protection-rule-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosdns-protection-rule-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-responseMessagesSource`` = { pointer = None }

type ``dosdns-protection-rule-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosdns-protection-rule-responseMessagesSource``> }
    ///Creates an instance of dosdns-protection-rule-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosdns-protection-rule-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosdns-protection-rule-response`` =
    { errors: Option<list<``dosdns-protection-rule-responseErrors``>>
      messages: Option<list<``dosdns-protection-rule-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosDnsProtectionRule> }
    ///Creates an instance of dosdns-protection-rule-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosdns-protection-rule-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dosexpression-filter-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosexpression-filter-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-list-responseErrorsSource`` = { pointer = None }

type ``dosexpression-filter-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosexpression-filter-list-responseErrorsSource``> }
    ///Creates an instance of dosexpression-filter-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosexpression-filter-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosexpression-filter-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosexpression-filter-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-list-responseMessagesSource`` = { pointer = None }

type ``dosexpression-filter-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosexpression-filter-list-responseMessagesSource``> }
    ///Creates an instance of dosexpression-filter-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosexpression-filter-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosexpression-filter-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dosexpression-filter-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dosexpression-filter-list-response`` =
    { errors: Option<list<``dosexpression-filter-list-responseErrors``>>
      messages: Option<list<``dosexpression-filter-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dosexpression-filter-list-responseResultinfo``>
      result: Option<list<dosExpressionFilter>> }
    ///Creates an instance of dosexpression-filter-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dosexpression-filter-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosexpression-filter-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-responseErrorsSource`` = { pointer = None }

type ``dosexpression-filter-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosexpression-filter-responseErrorsSource``> }
    ///Creates an instance of dosexpression-filter-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosexpression-filter-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosexpression-filter-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosexpression-filter-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-responseMessagesSource`` = { pointer = None }

type ``dosexpression-filter-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosexpression-filter-responseMessagesSource``> }
    ///Creates an instance of dosexpression-filter-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosexpression-filter-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosexpression-filter-response`` =
    { errors: Option<list<``dosexpression-filter-responseErrors``>>
      messages: Option<list<``dosexpression-filter-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosExpressionFilter> }
    ///Creates an instance of dosexpression-filter-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosexpression-filter-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dosinfra-prefix-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosinfra-prefix-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-list-responseErrorsSource`` = { pointer = None }

type ``dosinfra-prefix-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosinfra-prefix-list-responseErrorsSource``> }
    ///Creates an instance of dosinfra-prefix-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosinfra-prefix-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosinfra-prefix-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosinfra-prefix-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-list-responseMessagesSource`` = { pointer = None }

type ``dosinfra-prefix-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosinfra-prefix-list-responseMessagesSource``> }
    ///Creates an instance of dosinfra-prefix-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosinfra-prefix-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosinfra-prefix-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dosinfra-prefix-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dosinfra-prefix-list-response`` =
    { errors: Option<list<``dosinfra-prefix-list-responseErrors``>>
      messages: Option<list<``dosinfra-prefix-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dosinfra-prefix-list-responseResultinfo``>
      result: Option<list<dosInfraPrefix>> }
    ///Creates an instance of dosinfra-prefix-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dosinfra-prefix-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosinfra-prefix-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-responseErrorsSource`` = { pointer = None }

type ``dosinfra-prefix-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosinfra-prefix-responseErrorsSource``> }
    ///Creates an instance of dosinfra-prefix-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosinfra-prefix-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosinfra-prefix-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosinfra-prefix-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-responseMessagesSource`` = { pointer = None }

type ``dosinfra-prefix-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosinfra-prefix-responseMessagesSource``> }
    ///Creates an instance of dosinfra-prefix-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosinfra-prefix-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosinfra-prefix-response`` =
    { errors: Option<list<``dosinfra-prefix-responseErrors``>>
      messages: Option<list<``dosinfra-prefix-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosInfraPrefix> }
    ///Creates an instance of dosinfra-prefix-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosinfra-prefix-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dosprefix-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprefix-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-list-responseErrorsSource`` = { pointer = None }

type ``dosprefix-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprefix-list-responseErrorsSource``> }
    ///Creates an instance of dosprefix-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprefix-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprefix-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprefix-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-list-responseMessagesSource`` = { pointer = None }

type ``dosprefix-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprefix-list-responseMessagesSource``> }
    ///Creates an instance of dosprefix-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprefix-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprefix-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dosprefix-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dosprefix-list-response`` =
    { errors: Option<list<``dosprefix-list-responseErrors``>>
      messages: Option<list<``dosprefix-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dosprefix-list-responseResultinfo``>
      result: Option<list<dosPrefix>> }
    ///Creates an instance of dosprefix-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dosprefix-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprefix-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-responseErrorsSource`` = { pointer = None }

type ``dosprefix-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprefix-responseErrorsSource``> }
    ///Creates an instance of dosprefix-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprefix-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprefix-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprefix-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-responseMessagesSource`` = { pointer = None }

type ``dosprefix-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprefix-responseMessagesSource``> }
    ///Creates an instance of dosprefix-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprefix-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprefix-response`` =
    { errors: Option<list<``dosprefix-responseErrors``>>
      messages: Option<list<``dosprefix-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosPrefix> }
    ///Creates an instance of dosprefix-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprefix-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dosprotection-status-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprotection-status-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprotection-status-responseErrorsSource`` = { pointer = None }

type ``dosprotection-status-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprotection-status-responseErrorsSource``> }
    ///Creates an instance of dosprotection-status-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprotection-status-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprotection-status-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dosprotection-status-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprotection-status-responseMessagesSource`` = { pointer = None }

type ``dosprotection-status-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dosprotection-status-responseMessagesSource``> }
    ///Creates an instance of dosprotection-status-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dosprotection-status-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dosprotection-status-response`` =
    { errors: Option<list<``dosprotection-status-responseErrors``>>
      messages: Option<list<``dosprotection-status-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosProtectionStatus> }
    ///Creates an instance of dosprotection-status-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dosprotection-status-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dossyn-protection-rule-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dossyn-protection-rule-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-list-responseErrorsSource`` = { pointer = None }

type ``dossyn-protection-rule-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dossyn-protection-rule-list-responseErrorsSource``> }
    ///Creates an instance of dossyn-protection-rule-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dossyn-protection-rule-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dossyn-protection-rule-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dossyn-protection-rule-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-list-responseMessagesSource`` = { pointer = None }

type ``dossyn-protection-rule-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dossyn-protection-rule-list-responseMessagesSource``> }
    ///Creates an instance of dossyn-protection-rule-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dossyn-protection-rule-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dossyn-protection-rule-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dossyn-protection-rule-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dossyn-protection-rule-list-response`` =
    { errors: Option<list<``dossyn-protection-rule-list-responseErrors``>>
      messages: Option<list<``dossyn-protection-rule-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dossyn-protection-rule-list-responseResultinfo``>
      result: Option<list<dosSynProtectionRule>> }
    ///Creates an instance of dossyn-protection-rule-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dossyn-protection-rule-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dossyn-protection-rule-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-responseErrorsSource`` = { pointer = None }

type ``dossyn-protection-rule-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dossyn-protection-rule-responseErrorsSource``> }
    ///Creates an instance of dossyn-protection-rule-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dossyn-protection-rule-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dossyn-protection-rule-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dossyn-protection-rule-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-responseMessagesSource`` = { pointer = None }

type ``dossyn-protection-rule-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dossyn-protection-rule-responseMessagesSource``> }
    ///Creates an instance of dossyn-protection-rule-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dossyn-protection-rule-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dossyn-protection-rule-response`` =
    { errors: Option<list<``dossyn-protection-rule-responseErrors``>>
      messages: Option<list<``dossyn-protection-rule-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosSynProtectionRule> }
    ///Creates an instance of dossyn-protection-rule-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dossyn-protection-rule-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``dostcp-flow-protection-rule-list-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dostcp-flow-protection-rule-list-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-list-responseErrorsSource`` = { pointer = None }

type ``dostcp-flow-protection-rule-list-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dostcp-flow-protection-rule-list-responseErrorsSource``> }
    ///Creates an instance of dostcp-flow-protection-rule-list-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dostcp-flow-protection-rule-list-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dostcp-flow-protection-rule-list-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dostcp-flow-protection-rule-list-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-list-responseMessagesSource`` = { pointer = None }

type ``dostcp-flow-protection-rule-list-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dostcp-flow-protection-rule-list-responseMessagesSource``> }
    ///Creates an instance of dostcp-flow-protection-rule-list-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dostcp-flow-protection-rule-list-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dostcp-flow-protection-rule-list-responseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of dostcp-flow-protection-rule-list-responseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-list-responseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``dostcp-flow-protection-rule-list-response`` =
    { errors: Option<list<``dostcp-flow-protection-rule-list-responseErrors``>>
      messages: Option<list<``dostcp-flow-protection-rule-list-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``dostcp-flow-protection-rule-list-responseResultinfo``>
      result: Option<list<dosTcpFlowProtectionRule>> }
    ///Creates an instance of dostcp-flow-protection-rule-list-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-list-response`` =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type ``dostcp-flow-protection-rule-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dostcp-flow-protection-rule-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-responseErrorsSource`` = { pointer = None }

type ``dostcp-flow-protection-rule-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dostcp-flow-protection-rule-responseErrorsSource``> }
    ///Creates an instance of dostcp-flow-protection-rule-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dostcp-flow-protection-rule-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dostcp-flow-protection-rule-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of dostcp-flow-protection-rule-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-responseMessagesSource`` = { pointer = None }

type ``dostcp-flow-protection-rule-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``dostcp-flow-protection-rule-responseMessagesSource``> }
    ///Creates an instance of dostcp-flow-protection-rule-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``dostcp-flow-protection-rule-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``dostcp-flow-protection-rule-response`` =
    { errors: Option<list<``dostcp-flow-protection-rule-responseErrors``>>
      messages: Option<list<``dostcp-flow-protection-rule-responseMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<dosTcpFlowProtectionRule> }
    ///Creates an instance of dostcp-flow-protection-rule-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``dostcp-flow-protection-rule-response`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``magic-transitapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitapi-response-commonErrorsSource`` = { pointer = None }

type ``magic-transitapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitapi-response-commonErrorsSource``> }
    ///Creates an instance of magic-transitapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitapi-response-commonMessagesSource`` = { pointer = None }

type ``magic-transitapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitapi-response-commonMessagesSource``> }
    ///Creates an instance of magic-transitapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitapi-response-common`` =
    { errors: list<``magic-transitapi-response-commonErrors``>
      messages: list<``magic-transitapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of magic-transitapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magic-transitapi-response-commonErrors``>,
                          messages: list<``magic-transitapi-response-commonMessages``>,
                          success: bool): ``magic-transitapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``magic-transitapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of magic-transitapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``magic-transitapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magic-transitcolo`` =
    { ///Source colo city.
      city: Option<``magic-transitcolocity``>
      ///Source colo name.
      name: Option<``magic-transitcoloname``> }
    ///Creates an instance of magic-transitcolo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitcolo`` = { city = None; name = None }

type ``magic-transitcoloresult`` =
    { colo: Option<``magic-transitcolo``>
      ///Errors resulting from collecting traceroute from colo to target.
      error: Option<``magic-transiterror``>
      hops: Option<list<``magic-transithopresult``>>
      ///Aggregated statistics from all hops about the target.
      target_summary: Option<Newtonsoft.Json.Linq.JObject>
      ///Total time of traceroute in ms.
      traceroute_time_ms: Option<``magic-transittraceroutetimems``> }
    ///Creates an instance of magic-transitcoloresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitcoloresult`` =
        { colo = None
          error = None
          hops = None
          target_summary = None
          traceroute_time_ms = None }

type ``magic-transitendpointhealthcheck`` =
    { ///type of check to perform
      check_type: ``magic-transitchecktype``
      ///the IP address of the host to perform checks against
      endpoint: string
      ///Optional name associated with this check
      name: Option<string> }
    ///Creates an instance of magic-transitendpointhealthcheck with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (check_type: ``magic-transitchecktype``, endpoint: string): ``magic-transitendpointhealthcheck`` =
        { check_type = check_type
          endpoint = endpoint
          name = None }

type ``magic-transitendpointhealthcheckresponse`` =
    { ///type of check to perform
      check_type: ``magic-transitchecktype``
      ///the IP address of the host to perform checks against
      endpoint: string
      ///Optional name associated with this check
      name: Option<string>
      ///UUID.
      id: ``magic-transituuid`` }
    ///Creates an instance of magic-transitendpointhealthcheckresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (check_type: ``magic-transitchecktype``, endpoint: string, id: ``magic-transituuid``): ``magic-transitendpointhealthcheckresponse`` =
        { check_type = check_type
          endpoint = endpoint
          name = None
          id = id }

type ``magic-transitendpointhealthcheckresponsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsecollectionErrorsSource`` = { pointer = None }

type ``magic-transitendpointhealthcheckresponsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitendpointhealthcheckresponsecollectionErrorsSource``> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitendpointhealthcheckresponsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitendpointhealthcheckresponsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsecollectionMessagesSource`` = { pointer = None }

type ``magic-transitendpointhealthcheckresponsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitendpointhealthcheckresponsecollectionMessagesSource``> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitendpointhealthcheckresponsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitendpointhealthcheckresponsecollection`` =
    { errors: Option<list<``magic-transitendpointhealthcheckresponsecollectionErrors``>>
      messages: Option<list<``magic-transitendpointhealthcheckresponsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<``magic-transitendpointhealthcheckresponse``>> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``magic-transitendpointhealthcheckresponsesingleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsesingleErrorsSource`` = { pointer = None }

type ``magic-transitendpointhealthcheckresponsesingleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitendpointhealthcheckresponsesingleErrorsSource``> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitendpointhealthcheckresponsesingleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitendpointhealthcheckresponsesingleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsesingleMessagesSource`` = { pointer = None }

type ``magic-transitendpointhealthcheckresponsesingleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transitendpointhealthcheckresponsesingleMessagesSource``> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transitendpointhealthcheckresponsesingleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transitendpointhealthcheckresponsesingle`` =
    { errors: Option<list<``magic-transitendpointhealthcheckresponsesingleErrors``>>
      messages: Option<list<``magic-transitendpointhealthcheckresponsesingleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<``magic-transitendpointhealthcheckresponse``> }
    ///Creates an instance of magic-transitendpointhealthcheckresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitendpointhealthcheckresponsesingle`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``magic-transithopresult`` =
    { ///An array of node objects.
      nodes: Option<list<``magic-transitnoderesult``>>
      ///Number of packets where no response was received.
      packets_lost: Option<``magic-transitpacketslost``>
      ///Number of packets sent with specified TTL.
      packets_sent: Option<``magic-transitpacketssent``>
      ///The time to live (TTL).
      packets_ttl: Option<``magic-transitpacketsttl``> }
    ///Creates an instance of magic-transithopresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transithopresult`` =
        { nodes = None
          packets_lost = None
          packets_sent = None
          packets_ttl = None }

type ``magic-transitnoderesult`` =
    { ///AS number associated with the node object.
      asn: Option<``magic-transitasn``>
      ///IP address of the node.
      ip: Option<``magic-transitip``>
      ///Field appears if there is an additional annotation printed when the probe returns. Field also appears when running a GRE+ICMP traceroute to denote which traceroute a node comes from.
      labels: Option<``magic-transitlabels``>
      ///Maximum RTT in ms.
      max_rtt_ms: Option<``magic-transitmaxrttms``>
      ///Mean RTT in ms.
      mean_rtt_ms: Option<``magic-transitmeanrttms``>
      ///Minimum RTT in ms.
      min_rtt_ms: Option<``magic-transitminrttms``>
      ///Host name of the address, this may be the same as the IP address.
      name: Option<``magic-transitname``>
      ///Number of packets with a response from this node.
      packet_count: Option<``magic-transitpacketcount``>
      ///Standard deviation of the RTTs in ms.
      std_dev_rtt_ms: Option<``magic-transitstddevrttms``> }
    ///Creates an instance of magic-transitnoderesult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitnoderesult`` =
        { asn = None
          ip = None
          labels = None
          max_rtt_ms = None
          mean_rtt_ms = None
          min_rtt_ms = None
          name = None
          packet_count = None
          std_dev_rtt_ms = None }

type ``magic-transitoptions`` =
    { ///Max TTL.
      max_ttl: Option<``magic-transitmaxttl``>
      ///Type of packet sent.
      packet_type: Option<``magic-transitpackettype``>
      ///Number of packets sent at each TTL.
      packets_per_ttl: Option<``magic-transitpacketsperttl``>
      ///For UDP and TCP, specifies the destination port. For ICMP, specifies the initial ICMP sequence value. Default value 0 will choose the best value to use for each protocol.
      port: Option<``magic-transitport``>
      ///Set the time (in seconds) to wait for a response to a probe.
      wait_time: Option<``magic-transitwaittime``> }
    ///Creates an instance of magic-transitoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transitoptions`` =
        { max_ttl = None
          packet_type = None
          packets_per_ttl = None
          port = None
          wait_time = None }

type ``magic-transittargetresult`` =
    { colos: Option<list<``magic-transitcoloresult``>>
      ///The target hostname, IPv6, or IPv6 address.
      target: Option<``magic-transittarget``> }
    ///Creates an instance of magic-transittargetresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transittargetresult`` = { colos = None; target = None }

type ``magic-transittracerouteresponsecollectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transittracerouteresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transittracerouteresponsecollectionErrorsSource`` = { pointer = None }

type ``magic-transittracerouteresponsecollectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transittracerouteresponsecollectionErrorsSource``> }
    ///Creates an instance of magic-transittracerouteresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transittracerouteresponsecollectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transittracerouteresponsecollectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of magic-transittracerouteresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transittracerouteresponsecollectionMessagesSource`` = { pointer = None }

type ``magic-transittracerouteresponsecollectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``magic-transittracerouteresponsecollectionMessagesSource``> }
    ///Creates an instance of magic-transittracerouteresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-transittracerouteresponsecollectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``magic-transittracerouteresponsecollection`` =
    { errors: Option<list<``magic-transittracerouteresponsecollectionErrors``>>
      messages: Option<list<``magic-transittracerouteresponsecollectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<list<``magic-transittargetresult``>> }
    ///Creates an instance of magic-transittracerouteresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-transittracerouteresponsecollection`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``magic-visibility-mnmapi-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-collectionErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-collectionMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-collection`` =
    { errors: Option<list<``magic-visibility-mnmapi-response-collectionErrors``>>
      messages: Option<list<``magic-visibility-mnmapi-response-collectionMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<``magic-visibility-mnmresultinfo``> }
    ///Creates an instance of magic-visibility-mnmapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``magic-visibility-mnmapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-commonErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-commonMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-common`` =
    { errors: list<``magic-visibility-mnmapi-response-commonErrors``>
      messages: list<``magic-visibility-mnmapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magic-visibility-mnmapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magic-visibility-mnmapi-response-commonErrors``>,
                          messages: list<``magic-visibility-mnmapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``magic-visibility-mnmapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magic-visibility-mnmapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magic-visibility-mnmapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``magic-visibility-mnmapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magic-visibility-mnmapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-singleErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmapi-response-singleMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmapi-response-single`` =
    { errors: Option<list<``magic-visibility-mnmapi-response-singleErrors``>>
      messages: Option<list<``magic-visibility-mnmapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magic-visibility-mnmapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-mnmmnmconfig`` =
    { ///Fallback sampling rate of flow messages being sent in packets per second. This should match the packet sampling rate configured on the router.
      default_sampling: ``magic-visibility-mnmmnmconfigdefaultsampling``
      ///The account name.
      name: ``magic-visibility-mnmmnmconfigname``
      router_ips: ``magic-visibility-mnmmnmconfigrouterips``
      warp_devices: ``magic-visibility-mnmmnmconfigwarpdevices`` }
    ///Creates an instance of magic-visibility-mnmmnmconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (default_sampling: ``magic-visibility-mnmmnmconfigdefaultsampling``,
                          name: ``magic-visibility-mnmmnmconfigname``,
                          router_ips: ``magic-visibility-mnmmnmconfigrouterips``,
                          warp_devices: ``magic-visibility-mnmmnmconfigwarpdevices``): ``magic-visibility-mnmmnmconfig`` =
        { default_sampling = default_sampling
          name = name
          router_ips = router_ips
          warp_devices = warp_devices }

type ``magic-visibility-mnmmnmconfigsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmconfigsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmconfigsingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmconfigsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmconfigsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmconfigsingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmconfigsingleresponse`` =
    { errors: Option<list<``magic-visibility-mnmmnmconfigsingleresponseErrors``>>
      messages: Option<list<``magic-visibility-mnmmnmconfigsingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magic-visibility-mnmmnmconfigsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmmnmconfigsingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

///Object representing a warp device with an ID and name.
type ``magic-visibility-mnmmnmconfigwarpdevice`` =
    { ///Unique identifier for the warp device.
      id: string
      ///Name of the warp device.
      name: string
      ///IPv4 CIDR of the router sourcing flow data associated with this warp device. Only /32 addresses are currently supported.
      router_ip: string }
    ///Creates an instance of magic-visibility-mnmmnmconfigwarpdevice with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string, name: string, router_ip: string): ``magic-visibility-mnmmnmconfigwarpdevice`` =
        { id = id
          name = name
          router_ip = router_ip }

type ``magic-visibility-mnmmnmrule`` =
    { ///Toggle on if you would like Cloudflare to automatically advertise the IP Prefixes within the rule via Magic Transit when the rule is triggered. Only available for users of Magic Transit.
      automatic_advertisement: ``magic-visibility-mnmmnmruleautomaticadvertisement``
      ///The number of bits per second for the rule. When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
      bandwidth_threshold: Option<``magic-visibility-mnmmnmrulebandwidththreshold``>
      ///The amount of time that the rule threshold must be exceeded to send an alert notification. The final value must be equivalent to one of the following 8 values ["1m","5m","10m","15m","20m","30m","45m","60m"].
      duration: Option<``magic-visibility-mnmmnmruleduration``>
      ///The id of the rule. Must be unique.
      id: Option<``magic-visibility-mnmruleidentifier``>
      ///The name of the rule. Must be unique. Supports characters A-Z, a-z, 0-9, underscore (_), dash (-), period (.), and tilde (~). You can’t have a space in the rule name. Max 256 characters.
      name: ``magic-visibility-mnmmnmrulename``
      ///The number of packets per second for the rule. When this value is exceeded for the set duration, an alert notification is sent. Minimum of 1 and no maximum.
      packet_threshold: Option<``magic-visibility-mnmmnmrulepacketthreshold``>
      ///Prefix match type to be applied for a prefix auto advertisement when using an advanced_ddos rule.
      prefix_match: Option<``magic-visibility-mnmmnmruleprefixmatch``>
      prefixes: ``magic-visibility-mnmmnmruleipprefixes``
      ///MNM rule type.
      ``type``: ``magic-visibility-mnmmnmruletype``
      ///Level of sensitivity set for zscore rules.
      zscore_sensitivity: Option<``magic-visibility-mnmmnmrulezscoresensitivity``>
      ///Target of the zscore rule analysis.
      zscore_target: Option<``magic-visibility-mnmmnmrulezscoretarget``> }
    ///Creates an instance of magic-visibility-mnmmnmrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (automatic_advertisement: ``magic-visibility-mnmmnmruleautomaticadvertisement``,
                          name: ``magic-visibility-mnmmnmrulename``,
                          prefixes: ``magic-visibility-mnmmnmruleipprefixes``,
                          ``type``: ``magic-visibility-mnmmnmruletype``): ``magic-visibility-mnmmnmrule`` =
        { automatic_advertisement = automatic_advertisement
          bandwidth_threshold = None
          duration = None
          id = None
          name = name
          packet_threshold = None
          prefix_match = None
          prefixes = prefixes
          ``type`` = ``type``
          zscore_sensitivity = None
          zscore_target = None }

type ``magic-visibility-mnmmnmruleadvertisableresponse`` =
    { ///Toggle on if you would like Cloudflare to automatically advertise the IP Prefixes within the rule via Magic Transit when the rule is triggered. Only available for users of Magic Transit.
      automatic_advertisement: ``magic-visibility-mnmmnmruleautomaticadvertisement`` }
    ///Creates an instance of magic-visibility-mnmmnmruleadvertisableresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (automatic_advertisement: ``magic-visibility-mnmmnmruleautomaticadvertisement``): ``magic-visibility-mnmmnmruleadvertisableresponse`` =
        { automatic_advertisement = automatic_advertisement }

type ``magic-visibility-mnmmnmruleadvertisementsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmruleadvertisementsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmruleadvertisementsingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmruleadvertisementsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmruleadvertisementsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmruleadvertisementsingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmruleadvertisementsingleresponse`` =
    { errors: Option<list<``magic-visibility-mnmmnmruleadvertisementsingleresponseErrors``>>
      messages: Option<list<``magic-visibility-mnmmnmruleadvertisementsingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magic-visibility-mnmmnmruleadvertisementsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmmnmruleadvertisementsingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-mnmmnmrulescollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmrulescollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmrulescollectionresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmrulescollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmrulescollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmrulescollectionresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmrulescollectionresponse`` =
    { errors: Option<list<``magic-visibility-mnmmnmrulescollectionresponseErrors``>>
      messages: Option<list<``magic-visibility-mnmmnmrulescollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<``magic-visibility-mnmresultinfo``> }
    ///Creates an instance of magic-visibility-mnmmnmrulescollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmmnmrulescollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``magic-visibility-mnmmnmrulessingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmrulessingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmrulessingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmrulessingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmrulessingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmrulessingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmrulessingleresponse`` =
    { errors: Option<list<``magic-visibility-mnmmnmrulessingleresponseErrors``>>
      messages: Option<list<``magic-visibility-mnmmnmrulessingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magic-visibility-mnmmnmrulessingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmmnmrulessingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-mnmmnmvpcflowssingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmvpcflowssingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmvpcflowssingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmvpcflowssingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-mnmmnmvpcflowssingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-mnmmnmvpcflowssingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-mnmmnmvpcflowssingleresponse`` =
    { errors: Option<list<``magic-visibility-mnmmnmvpcflowssingleresponseErrors``>>
      messages: Option<list<``magic-visibility-mnmmnmvpcflowssingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magic-visibility-mnmmnmvpcflowssingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmmnmvpcflowssingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-mnmresultinfo`` =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of magic-visibility-mnmresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-mnmresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``magic-visibility-pcapsapi-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-collectionErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-collectionMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-collection`` =
    { errors: Option<list<``magic-visibility-pcapsapi-response-collectionErrors``>>
      messages: Option<list<``magic-visibility-pcapsapi-response-collectionMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``magic-visibility-pcapsresultinfo``> }
    ///Creates an instance of magic-visibility-pcapsapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapsapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``magic-visibility-pcapsapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-commonErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-commonMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-common`` =
    { errors: list<``magic-visibility-pcapsapi-response-commonErrors``>
      messages: list<``magic-visibility-pcapsapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of magic-visibility-pcapsapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magic-visibility-pcapsapi-response-commonErrors``>,
                          messages: list<``magic-visibility-pcapsapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``magic-visibility-pcapsapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magic-visibility-pcapsapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of magic-visibility-pcapsapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``magic-visibility-pcapsapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magic-visibility-pcapsapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-singleErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapsapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapsapi-response-singleMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapsapi-response-single`` =
    { errors: Option<list<``magic-visibility-pcapsapi-response-singleErrors``>>
      messages: Option<list<``magic-visibility-pcapsapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of magic-visibility-pcapsapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapsapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-pcapspcapscollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapscollectionresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapscollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapscollectionresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapscollectionresponse`` =
    { errors: Option<list<``magic-visibility-pcapspcapscollectionresponseErrors``>>
      messages: Option<list<``magic-visibility-pcapspcapscollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``magic-visibility-pcapsresultinfo``> }
    ///Creates an instance of magic-visibility-pcapspcapscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapscollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

///The packet capture filter. When this field is empty, all packets are captured.
type ``magic-visibility-pcapspcapsfilterv1`` =
    { ///The destination IP address of the packet.
      destination_address: Option<string>
      ///The destination port of the packet.
      destination_port: Option<float>
      ///The protocol number of the packet.
      protocol: Option<float>
      ///The source IP address of the packet.
      source_address: Option<string>
      ///The source port of the packet.
      source_port: Option<float> }
    ///Creates an instance of magic-visibility-pcapspcapsfilterv1 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapsfilterv1`` =
        { destination_address = None
          destination_port = None
          protocol = None
          source_address = None
          source_port = None }

type ``magic-visibility-pcapspcapsownershipcollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapsownershipcollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapsownershipcollectionErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapsownershipcollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapsownershipcollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapsownershipcollectionMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapsownershipcollection`` =
    { errors: Option<list<``magic-visibility-pcapspcapsownershipcollectionErrors``>>
      messages: Option<list<``magic-visibility-pcapspcapsownershipcollectionMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``magic-visibility-pcapsresultinfo``> }
    ///Creates an instance of magic-visibility-pcapspcapsownershipcollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapsownershipcollection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``magic-visibility-pcapspcapsownershiprequest`` =
    { ///The full URI for the bucket. This field only applies to `full` packet captures.
      destination_conf: ``magic-visibility-pcapspcapsdestinationconf`` }
    ///Creates an instance of magic-visibility-pcapspcapsownershiprequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination_conf: ``magic-visibility-pcapspcapsdestinationconf``): ``magic-visibility-pcapspcapsownershiprequest`` =
        { destination_conf = destination_conf }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "success">] Success
    | [<CompiledName "failed">] Failed
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Success -> "success"
        | Failed -> "failed"

type ``magic-visibility-pcapspcapsownershipresponse`` =
    { ///The full URI for the bucket. This field only applies to `full` packet captures.
      destination_conf: ``magic-visibility-pcapspcapsdestinationconf``
      ///The ownership challenge filename stored in the bucket.
      filename: ``magic-visibility-pcapspcapsownershipchallenge``
      ///The bucket ID associated with the packet captures API.
      id: string
      ///The status of the ownership challenge. Can be pending, success or failed.
      status: Status
      ///The RFC 3339 timestamp when the bucket was added to packet captures API.
      submitted: string
      ///The RFC 3339 timestamp when the bucket was validated.
      validated: Option<string> }
    ///Creates an instance of magic-visibility-pcapspcapsownershipresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination_conf: ``magic-visibility-pcapspcapsdestinationconf``,
                          filename: ``magic-visibility-pcapspcapsownershipchallenge``,
                          id: string,
                          status: Status,
                          submitted: string): ``magic-visibility-pcapspcapsownershipresponse`` =
        { destination_conf = destination_conf
          filename = filename
          id = id
          status = status
          submitted = submitted
          validated = None }

type ``magic-visibility-pcapspcapsownershipsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapsownershipsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapsownershipsingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapsownershipsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapsownershipsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapsownershipsingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapsownershipsingleresponse`` =
    { errors: Option<list<``magic-visibility-pcapspcapsownershipsingleresponseErrors``>>
      messages: Option<list<``magic-visibility-pcapspcapsownershipsingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of magic-visibility-pcapspcapsownershipsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapsownershipsingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-pcapspcapsownershipvalidaterequest`` =
    { ///The full URI for the bucket. This field only applies to `full` packet captures.
      destination_conf: ``magic-visibility-pcapspcapsdestinationconf``
      ///The ownership challenge filename stored in the bucket.
      ownership_challenge: ``magic-visibility-pcapspcapsownershipchallenge`` }
    ///Creates an instance of magic-visibility-pcapspcapsownershipvalidaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination_conf: ``magic-visibility-pcapspcapsdestinationconf``,
                          ownership_challenge: ``magic-visibility-pcapspcapsownershipchallenge``): ``magic-visibility-pcapspcapsownershipvalidaterequest`` =
        { destination_conf = destination_conf
          ownership_challenge = ownership_challenge }

type ``magic-visibility-pcapspcapsrequestfull`` =
    { ///The maximum number of bytes to capture. This field only applies to `full` packet captures.
      byte_limit: Option<``magic-visibility-pcapspcapsbytelimit``>
      ///The name of the data center used for the packet capture. This can be a specific colo (ord02) or a multi-colo name (ORD). This field only applies to `full` packet captures.
      colo_name: ``magic-visibility-pcapspcapscoloname``
      ///The full URI for the bucket. This field only applies to `full` packet captures.
      destination_conf: ``magic-visibility-pcapspcapsdestinationconf``
      ///The packet capture filter. When this field is empty, all packets are captured.
      filter_v1: Option<``magic-visibility-pcapspcapsfilterv1``>
      ///The limit of packets contained in a packet capture.
      packet_limit: Option<``magic-visibility-pcapspcapspacketlimit``>
      ///The system used to collect packet captures.
      system: ``magic-visibility-pcapspcapssystem``
      ///The packet capture duration in seconds.
      time_limit: ``magic-visibility-pcapspcapstimelimitfull``
      ///The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.
      ``type``: ``magic-visibility-pcapspcapstype`` }
    ///Creates an instance of magic-visibility-pcapspcapsrequestfull with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (colo_name: ``magic-visibility-pcapspcapscoloname``,
                          destination_conf: ``magic-visibility-pcapspcapsdestinationconf``,
                          system: ``magic-visibility-pcapspcapssystem``,
                          time_limit: ``magic-visibility-pcapspcapstimelimitfull``,
                          ``type``: ``magic-visibility-pcapspcapstype``): ``magic-visibility-pcapspcapsrequestfull`` =
        { byte_limit = None
          colo_name = colo_name
          destination_conf = destination_conf
          filter_v1 = None
          packet_limit = None
          system = system
          time_limit = time_limit
          ``type`` = ``type`` }

type ``magic-visibility-pcapspcapsrequestsimple`` =
    { ///The packet capture filter. When this field is empty, all packets are captured.
      filter_v1: Option<``magic-visibility-pcapspcapsfilterv1``>
      ///The RFC 3339 offset timestamp from which to query backwards for packets. Must be within the last 24h. When this field is empty, defaults to time of request.
      offset_time: Option<``magic-visibility-pcapspcapsoffsettime``>
      ///The limit of packets contained in a packet capture.
      packet_limit: ``magic-visibility-pcapspcapspacketlimit``
      ///The system used to collect packet captures.
      system: ``magic-visibility-pcapspcapssystem``
      ///The packet capture duration in seconds.
      time_limit: ``magic-visibility-pcapspcapstimelimitsampled``
      ///The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.
      ``type``: ``magic-visibility-pcapspcapstype`` }
    ///Creates an instance of magic-visibility-pcapspcapsrequestsimple with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (packet_limit: ``magic-visibility-pcapspcapspacketlimit``,
                          system: ``magic-visibility-pcapspcapssystem``,
                          time_limit: ``magic-visibility-pcapspcapstimelimitsampled``,
                          ``type``: ``magic-visibility-pcapspcapstype``): ``magic-visibility-pcapspcapsrequestsimple`` =
        { filter_v1 = None
          offset_time = None
          packet_limit = packet_limit
          system = system
          time_limit = time_limit
          ``type`` = ``type`` }

type ``magic-visibility-pcapspcapsresponsefull`` =
    { ///The maximum number of bytes to capture. This field only applies to `full` packet captures.
      byte_limit: Option<``magic-visibility-pcapspcapsbytelimit``>
      ///The name of the data center used for the packet capture. This can be a specific colo (ord02) or a multi-colo name (ORD). This field only applies to `full` packet captures.
      colo_name: Option<``magic-visibility-pcapspcapscoloname``>
      ///The full URI for the bucket. This field only applies to `full` packet captures.
      destination_conf: Option<``magic-visibility-pcapspcapsdestinationconf``>
      ///An error message that describes why the packet capture failed. This field only applies to `full` packet captures.
      error_message: Option<``magic-visibility-pcapspcapserrormessage``>
      ///The packet capture filter. When this field is empty, all packets are captured.
      filter_v1: Option<``magic-visibility-pcapspcapsfilterv1``>
      ///The ID for the packet capture.
      id: Option<``magic-visibility-pcapspcapsid``>
      ///The number of packets captured.
      packets_captured: Option<``magic-visibility-pcapspcapspacketscaptured``>
      ///The status of the packet capture request.
      status: Option<``magic-visibility-pcapspcapsstatus``>
      ///The RFC 3339 timestamp when stopping the packet capture was requested. This field only applies to `full` packet captures.
      stop_requested: Option<``magic-visibility-pcapspcapsstoprequested``>
      ///The RFC 3339 timestamp when the packet capture was created.
      submitted: Option<``magic-visibility-pcapspcapssubmitted``>
      ///The system used to collect packet captures.
      system: Option<``magic-visibility-pcapspcapssystem``>
      ///The packet capture duration in seconds.
      time_limit: Option<``magic-visibility-pcapspcapstimelimitfull``>
      ///The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.
      ``type``: Option<``magic-visibility-pcapspcapstype``> }
    ///Creates an instance of magic-visibility-pcapspcapsresponsefull with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapsresponsefull`` =
        { byte_limit = None
          colo_name = None
          destination_conf = None
          error_message = None
          filter_v1 = None
          id = None
          packets_captured = None
          status = None
          stop_requested = None
          submitted = None
          system = None
          time_limit = None
          ``type`` = None }

type ``magic-visibility-pcapspcapsresponsesimple`` =
    { ///The packet capture filter. When this field is empty, all packets are captured.
      filter_v1: Option<``magic-visibility-pcapspcapsfilterv1``>
      ///The ID for the packet capture.
      id: Option<``magic-visibility-pcapspcapsid``>
      ///The RFC 3339 offset timestamp from which to query backwards for packets. Must be within the last 24h. When this field is empty, defaults to time of request.
      offset_time: Option<``magic-visibility-pcapspcapsoffsettime``>
      ///The status of the packet capture request.
      status: Option<``magic-visibility-pcapspcapsstatus``>
      ///The RFC 3339 timestamp when the packet capture was created.
      submitted: Option<``magic-visibility-pcapspcapssubmitted``>
      ///The system used to collect packet captures.
      system: Option<``magic-visibility-pcapspcapssystem``>
      ///The packet capture duration in seconds.
      time_limit: Option<``magic-visibility-pcapspcapstimelimitsampled``>
      ///The type of packet capture. `Simple` captures sampled packets, and `full` captures entire payloads and non-sampled packets.
      ``type``: Option<``magic-visibility-pcapspcapstype``> }
    ///Creates an instance of magic-visibility-pcapspcapsresponsesimple with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapsresponsesimple`` =
        { filter_v1 = None
          id = None
          offset_time = None
          status = None
          submitted = None
          system = None
          time_limit = None
          ``type`` = None }

type ``magic-visibility-pcapspcapssingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapssingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapssingleresponseErrors`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapssingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magic-visibility-pcapspcapssingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magic-visibility-pcapspcapssingleresponseMessages`` =
        { code = code; message = message }

type ``magic-visibility-pcapspcapssingleresponse`` =
    { errors: Option<list<``magic-visibility-pcapspcapssingleresponseErrors``>>
      messages: Option<list<``magic-visibility-pcapspcapssingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of magic-visibility-pcapspcapssingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapspcapssingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magic-visibility-pcapsresultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of magic-visibility-pcapsresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magic-visibility-pcapsresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

///Custom app defined for an account.
type magicaccountapp =
    { ///Magic account app ID.
      account_app_id: magicaccountappid
      ///FQDNs to associate with traffic decisions.
      hostnames: Option<magicapphostnames>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      ip_subnets: Option<magicappsubnets>
      ///Display name for the app.
      name: Option<magicappname>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      source_subnets: Option<magicappsourcesubnets>
      ///Category of the app.
      ``type``: Option<magicapptype> }
    ///Creates an instance of magicaccountapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_app_id: magicaccountappid): magicaccountapp =
        { account_app_id = account_app_id
          hostnames = None
          ip_subnets = None
          name = None
          source_subnets = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Protocols =
    | [<CompiledName "tcp">] Tcp
    | [<CompiledName "udp">] Udp
    | [<CompiledName "icmp">] Icmp
    member this.Format() =
        match this with
        | Tcp -> "tcp"
        | Udp -> "udp"
        | Icmp -> "icmp"

///Bidirectional ACL policy for network traffic within a site.
type magicacl =
    { ///Description for the ACL.
      description: Option<string>
      ///The desired forwarding action for this ACL policy. If set to "false", the policy will forward traffic to Cloudflare. If set to "true", the policy will forward traffic locally on the Magic Connector. If not included in request, will default to false.
      forward_locally: Option<magicforwardlocally>
      ///Identifier
      id: Option<magicidentifier>
      lan_1: Option<``magiclan-acl-configuration``>
      lan_2: Option<``magiclan-acl-configuration``>
      ///The name of the ACL.
      name: Option<string>
      protocols: Option<list<Protocols>>
      ///The desired traffic direction for this ACL policy. If set to "false", the policy will allow bidirectional traffic. If set to "true", the policy will only allow traffic in one direction. If not included in request, will default to false.
      unidirectional: Option<magicunidirectional> }
    ///Creates an instance of magicacl with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicacl =
        { description = None
          forward_locally = None
          id = None
          lan_1 = None
          lan_2 = None
          name = None
          protocols = None
          unidirectional = None }

type magicacldeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicacldeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicacldeletedresponseErrors =
        { code = code; message = message }

type magicacldeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicacldeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicacldeletedresponseMessages =
        { code = code; message = message }

type magicacldeletedresponse =
    { errors: Option<list<magicacldeletedresponseErrors>>
      messages: Option<list<magicacldeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicacldeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicacldeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicaclmodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicaclmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclmodifiedresponseErrors =
        { code = code; message = message }

type magicaclmodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicaclmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclmodifiedresponseMessages =
        { code = code; message = message }

type magicaclmodifiedresponse =
    { errors: Option<list<magicaclmodifiedresponseErrors>>
      messages: Option<list<magicaclmodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicaclmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicaclmodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicaclsingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicaclsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclsingleresponseErrors = { code = code; message = message }

type magicaclsingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicaclsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclsingleresponseMessages =
        { code = code; message = message }

type magicaclsingleresponse =
    { errors: Option<list<magicaclsingleresponseErrors>>
      messages: Option<list<magicaclsingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicaclsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicaclsingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magicaclupdaterequestProtocols =
    | [<CompiledName "tcp">] Tcp
    | [<CompiledName "udp">] Udp
    | [<CompiledName "icmp">] Icmp
    member this.Format() =
        match this with
        | Tcp -> "tcp"
        | Udp -> "udp"
        | Icmp -> "icmp"

type magicaclupdaterequest =
    { ///Description for the ACL.
      description: Option<string>
      ///The desired forwarding action for this ACL policy. If set to "false", the policy will forward traffic to Cloudflare. If set to "true", the policy will forward traffic locally on the Magic Connector. If not included in request, will default to false.
      forward_locally: Option<magicforwardlocally>
      lan_1: Option<``magiclan-acl-configuration``>
      lan_2: Option<``magiclan-acl-configuration``>
      ///The name of the ACL.
      name: Option<string>
      protocols: Option<list<magicaclupdaterequestProtocols>>
      ///The desired traffic direction for this ACL policy. If set to "false", the policy will allow bidirectional traffic. If set to "true", the policy will only allow traffic in one direction. If not included in request, will default to false.
      unidirectional: Option<magicunidirectional> }
    ///Creates an instance of magicaclupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicaclupdaterequest =
        { description = None
          forward_locally = None
          lan_1 = None
          lan_2 = None
          name = None
          protocols = None
          unidirectional = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magicaclsaddsinglerequestProtocols =
    | [<CompiledName "tcp">] Tcp
    | [<CompiledName "udp">] Udp
    | [<CompiledName "icmp">] Icmp
    member this.Format() =
        match this with
        | Tcp -> "tcp"
        | Udp -> "udp"
        | Icmp -> "icmp"

///Bidirectional ACL policy for local network traffic within a site.
type magicaclsaddsinglerequest =
    { ///Description for the ACL.
      description: Option<string>
      ///The desired forwarding action for this ACL policy. If set to "false", the policy will forward traffic to Cloudflare. If set to "true", the policy will forward traffic locally on the Magic Connector. If not included in request, will default to false.
      forward_locally: Option<magicforwardlocally>
      lan_1: ``magiclan-acl-configuration``
      lan_2: ``magiclan-acl-configuration``
      ///The name of the ACL.
      name: string
      protocols: Option<list<magicaclsaddsinglerequestProtocols>>
      ///The desired traffic direction for this ACL policy. If set to "false", the policy will allow bidirectional traffic. If set to "true", the policy will only allow traffic in one direction. If not included in request, will default to false.
      unidirectional: Option<magicunidirectional> }
    ///Creates an instance of magicaclsaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (lan_1: ``magiclan-acl-configuration``, lan_2: ``magiclan-acl-configuration``, name: string): magicaclsaddsinglerequest =
        { description = None
          forward_locally = None
          lan_1 = lan_1
          lan_2 = lan_2
          name = name
          protocols = None
          unidirectional = None }

type magicaclscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicaclscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclscollectionresponseErrors =
        { code = code; message = message }

type magicaclscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicaclscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicaclscollectionresponseMessages =
        { code = code; message = message }

type magicaclscollectionresponse =
    { errors: Option<list<magicaclscollectionresponseErrors>>
      messages: Option<list<magicaclscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicaclscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicaclscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapi-response-commonErrors`` =
        { code = code; message = message }

type ``magicapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapi-response-commonMessages`` =
        { code = code; message = message }

type ``magicapi-response-common`` =
    { errors: list<``magicapi-response-commonErrors``>
      messages: list<``magicapi-response-commonMessages``>
      result: Newtonsoft.Json.Linq.JToken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magicapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magicapi-response-commonErrors``>,
                          messages: list<``magicapi-response-commonMessages``>,
                          result: Newtonsoft.Json.Linq.JToken,
                          success: bool): ``magicapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magicapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magicapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``magicapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magicapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapi-response-singleErrors`` =
        { code = code; message = message }

type ``magicapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapi-response-singleMessages`` =
        { code = code; message = message }

type ``magicapi-response-single`` =
    { errors: Option<list<``magicapi-response-singleErrors``>>
      messages: Option<list<``magicapi-response-singleMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type magicappaddsinglerequest =
    { ///FQDNs to associate with traffic decisions.
      hostnames: Option<magicapphostnames>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      ip_subnets: Option<magicappsubnets>
      ///Display name for the app.
      name: magicappname
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      source_subnets: Option<magicappsourcesubnets>
      ///Category of the app.
      ``type``: magicapptype }
    ///Creates an instance of magicappaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: magicappname, ``type``: magicapptype): magicappaddsinglerequest =
        { hostnames = None
          ip_subnets = None
          name = name
          source_subnets = None
          ``type`` = ``type`` }

///Traffic decision configuration for an app.
type magicappconfig =
    { ///Whether to breakout traffic to the app's endpoints directly. Null preserves default behavior.
      breakout: Option<magicappbreakout>
      ///Identifier
      id: Option<magicidentifier>
      ///WAN interfaces to prefer over default WANs, highest-priority first. Can only be specified for breakout rules (breakout must be true).
      preferred_wans: Option<magicappbreakoutpreferredwans>
      ///Priority of traffic. 0 is default, anything greater is prioritized. (Currently only 0 and 1 are supported)
      priority: Option<magicapppriority>
      ///Identifier
      site_id: Option<magicidentifier> }
    ///Creates an instance of magicappconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappconfig =
        { breakout = None
          id = None
          preferred_wans = None
          priority = None
          site_id = None }

type magicappconfigaddsinglerequest =
    { ///Whether to breakout traffic to the app's endpoints directly. Null preserves default behavior.
      breakout: Option<magicappbreakout>
      ///WAN interfaces to prefer over default WANs, highest-priority first. Can only be specified for breakout rules (breakout must be true).
      preferred_wans: Option<magicappbreakoutpreferredwans>
      ///Priority of traffic. 0 is default, anything greater is prioritized. (Currently only 0 and 1 are supported)
      priority: Option<magicapppriority> }
    ///Creates an instance of magicappconfigaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappconfigaddsinglerequest =
        { breakout = None
          preferred_wans = None
          priority = None }

type magicappconfigsingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicappconfigsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappconfigsingleresponseErrors =
        { code = code; message = message }

type magicappconfigsingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicappconfigsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappconfigsingleresponseMessages =
        { code = code; message = message }

type magicappconfigsingleresponse =
    { errors: Option<list<magicappconfigsingleresponseErrors>>
      messages: Option<list<magicappconfigsingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JObject>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicappconfigsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappconfigsingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicappconfigupdaterequest =
    { ///Magic account app ID.
      account_app_id: Option<magicaccountappid>
      ///Whether to breakout traffic to the app's endpoints directly. Null preserves default behavior.
      breakout: Option<magicappbreakout>
      ///Managed app ID.
      managed_app_id: Option<magicmanagedappid>
      ///WAN interfaces to prefer over default WANs, highest-priority first. Can only be specified for breakout rules (breakout must be true).
      preferred_wans: Option<magicappbreakoutpreferredwans>
      ///Priority of traffic. 0 is default, anything greater is prioritized. (Currently only 0 and 1 are supported)
      priority: Option<magicapppriority> }
    ///Creates an instance of magicappconfigupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappconfigupdaterequest =
        { account_app_id = None
          breakout = None
          managed_app_id = None
          preferred_wans = None
          priority = None }

type magicappconfigscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicappconfigscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappconfigscollectionresponseErrors =
        { code = code; message = message }

type magicappconfigscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicappconfigscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappconfigscollectionresponseMessages =
        { code = code; message = message }

type magicappconfigscollectionresponse =
    { errors: Option<list<magicappconfigscollectionresponseErrors>>
      messages: Option<list<magicappconfigscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JObject>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicappconfigscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappconfigscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicappsingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicappsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappsingleresponseErrors = { code = code; message = message }

type magicappsingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicappsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappsingleresponseMessages =
        { code = code; message = message }

type magicappsingleresponse =
    { errors: Option<list<magicappsingleresponseErrors>>
      messages: Option<list<magicappsingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JObject>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicappsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappsingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicappupdaterequest =
    { ///FQDNs to associate with traffic decisions.
      hostnames: Option<magicapphostnames>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      ip_subnets: Option<magicappsubnets>
      ///Display name for the app.
      name: Option<magicappname>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      source_subnets: Option<magicappsourcesubnets>
      ///Category of the app.
      ``type``: Option<magicapptype> }
    ///Creates an instance of magicappupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappupdaterequest =
        { hostnames = None
          ip_subnets = None
          name = None
          source_subnets = None
          ``type`` = None }

type ``magicapps-response-arrayErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicapps-response-arrayErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapps-response-arrayErrors`` =
        { code = code; message = message }

type ``magicapps-response-arrayMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicapps-response-arrayMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapps-response-arrayMessages`` =
        { code = code; message = message }

type ``magicapps-response-array`` =
    { errors: list<``magicapps-response-arrayErrors``>
      messages: list<``magicapps-response-arrayMessages``>
      result: list<string>
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magicapps-response-array with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magicapps-response-arrayErrors``>,
                          messages: list<``magicapps-response-arrayMessages``>,
                          result: list<string>,
                          success: bool): ``magicapps-response-array`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``magicapps-response-objectErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicapps-response-objectErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapps-response-objectErrors`` =
        { code = code; message = message }

type ``magicapps-response-objectMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicapps-response-objectMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicapps-response-objectMessages`` =
        { code = code; message = message }

type ``magicapps-response-object`` =
    { errors: list<``magicapps-response-objectErrors``>
      messages: list<``magicapps-response-objectMessages``>
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of magicapps-response-object with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``magicapps-response-objectErrors``>,
                          messages: list<``magicapps-response-objectMessages``>,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``magicapps-response-object`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type magicappscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicappscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappscollectionresponseErrors =
        { code = code; message = message }

type magicappscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicappscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicappscollectionresponseMessages =
        { code = code; message = message }

type magicappscollectionresponse =
    { errors: Option<list<magicappscollectionresponseErrors>>
      messages: Option<list<magicappscollectionresponseMessages>>
      result: Option<list<string>>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicappscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicappscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicbgpconfig =
    { ///ASN used on the customer end of the BGP session
      customer_asn: int
      ///Prefixes in this list will be advertised to the customer device, in addition to the routes in the Magic routing table.
      extra_prefixes: Option<list<string>>
      ///MD5 key to use for session authentication.
      ///Note that *this is not a security measure*. MD5 is not a valid security mechanism, and the
      ///key is not treated as a secret value. This is *only* supported for preventing
      ///misconfiguration, not for defending against malicious attacks.
      ///The MD5 key, if set, must be of non-zero length and consist only of the following types of
      ///character:
      ///* ASCII alphanumerics: `[a-zA-Z0-9]`
      ///* Special characters in the set `'!@#$%^&amp;*()+[]{}&amp;lt;&amp;gt;/.,;:_-~`= \|`
      ///In other words, MD5 keys may contain any printable ASCII character aside from newline (0x0A),
      ///quotation mark (`"`), vertical tab (0x0B), carriage return (0x0D), tab (0x09), form feed
      ///(0x0C), and the question mark (`?`). Requests specifying an MD5 key with one or more of
      ///these disallowed characters will be rejected.
      md5_key: Option<string> }
    ///Creates an instance of magicbgpconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (customer_asn: int): magicbgpconfig =
        { customer_asn = customer_asn
          extra_prefixes = None
          md5_key = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type State =
    | [<CompiledName "BGP_DOWN">] BGP_DOWN
    | [<CompiledName "BGP_UP">] BGP_UP
    | [<CompiledName "BGP_ESTABLISHING">] BGP_ESTABLISHING
    member this.Format() =
        match this with
        | BGP_DOWN -> "BGP_DOWN"
        | BGP_UP -> "BGP_UP"
        | BGP_ESTABLISHING -> "BGP_ESTABLISHING"

type magicbgpstatuswithstate =
    { bgp_state: Option<string>
      cf_speaker_ip: Option<string>
      cf_speaker_port: Option<int>
      customer_speaker_ip: Option<string>
      customer_speaker_port: Option<int>
      state: State
      tcp_established: bool
      updated_at: System.DateTimeOffset }
    ///Creates an instance of magicbgpstatuswithstate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (state: State, tcp_established: bool, updated_at: System.DateTimeOffset): magicbgpstatuswithstate =
        { bgp_state = None
          cf_speaker_ip = None
          cf_speaker_port = None
          customer_speaker_ip = None
          customer_speaker_port = None
          state = state
          tcp_established = tcp_established
          updated_at = updated_at }

type ``magiccomponents-schemas-modifiedtunnelscollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-modifiedtunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-modifiedtunnelscollectionresponseErrors`` =
        { code = code; message = message }

type ``magiccomponents-schemas-modifiedtunnelscollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-modifiedtunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-modifiedtunnelscollectionresponseMessages`` =
        { code = code; message = message }

type ``magiccomponents-schemas-modifiedtunnelscollectionresponse`` =
    { errors: Option<list<``magiccomponents-schemas-modifiedtunnelscollectionresponseErrors``>>
      messages: Option<list<``magiccomponents-schemas-modifiedtunnelscollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccomponents-schemas-modifiedtunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magiccomponents-schemas-modifiedtunnelscollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magiccomponents-schemas-tunnelmodifiedresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelmodifiedresponseErrors`` =
        { code = code; message = message }

type ``magiccomponents-schemas-tunnelmodifiedresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelmodifiedresponseMessages`` =
        { code = code; message = message }

type Result =
    { modified: Option<bool>
      modified_interconnect: Option<magicinterconnect> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result =
        { modified = None
          modified_interconnect = None }

type ``magiccomponents-schemas-tunnelmodifiedresponse`` =
    { errors: Option<list<``magiccomponents-schemas-tunnelmodifiedresponseErrors``>>
      messages: Option<list<``magiccomponents-schemas-tunnelmodifiedresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccomponents-schemas-tunnelmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magiccomponents-schemas-tunnelmodifiedresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magiccomponents-schemas-tunnelsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelsingleresponseErrors`` =
        { code = code; message = message }

type ``magiccomponents-schemas-tunnelsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelsingleresponseMessages`` =
        { code = code; message = message }

type ``magiccomponents-schemas-tunnelsingleresponseResult`` =
    { interconnect: Option<magicinterconnect> }
    ///Creates an instance of magiccomponents-schemas-tunnelsingleresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magiccomponents-schemas-tunnelsingleresponseResult`` = { interconnect = None }

type ``magiccomponents-schemas-tunnelsingleresponse`` =
    { errors: Option<list<``magiccomponents-schemas-tunnelsingleresponseErrors``>>
      messages: Option<list<``magiccomponents-schemas-tunnelsingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccomponents-schemas-tunnelsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magiccomponents-schemas-tunnelsingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magiccomponents-schemas-tunnelscollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelscollectionresponseErrors`` =
        { code = code; message = message }

type ``magiccomponents-schemas-tunnelscollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magiccomponents-schemas-tunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magiccomponents-schemas-tunnelscollectionresponseMessages`` =
        { code = code; message = message }

type ``magiccomponents-schemas-tunnelscollectionresponse`` =
    { errors: Option<list<``magiccomponents-schemas-tunnelscollectionresponseErrors``>>
      messages: Option<list<``magiccomponents-schemas-tunnelscollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccomponents-schemas-tunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magiccomponents-schemas-tunnelscollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type magiccreategretunnelrequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      ///The IP address assigned to the Cloudflare side of the GRE tunnel.
      cloudflare_gre_endpoint: magiccloudflaregreendpoint
      ///The IP address assigned to the customer side of the GRE tunnel.
      customer_gre_endpoint: magiccustomergreendpoint
      ///An optional description of the GRE tunnel.
      description: Option<``magicschemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: magicinterfaceaddress
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.
      mtu: Option<magicmtu>
      ///The name of the tunnel. The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
      name: magicgretunnelname
      ///Time To Live (TTL) in number of hops of the GRE tunnel.
      ttl: Option<magicttl> }
    ///Creates an instance of magiccreategretunnelrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloudflare_gre_endpoint: magiccloudflaregreendpoint,
                          customer_gre_endpoint: magiccustomergreendpoint,
                          interface_address: magicinterfaceaddress,
                          name: magicgretunnelname): magiccreategretunnelrequest =
        { automatic_return_routing = None
          bgp = None
          cloudflare_gre_endpoint = cloudflare_gre_endpoint
          customer_gre_endpoint = customer_gre_endpoint
          description = None
          health_check = None
          interface_address = interface_address
          interface_address6 = None
          mtu = None
          name = name
          ttl = None }

type magiccreategretunnelresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiccreategretunnelresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiccreategretunnelresponseErrors =
        { code = code; message = message }

type magiccreategretunnelresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiccreategretunnelresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiccreategretunnelresponseMessages =
        { code = code; message = message }

type magiccreategretunnelresponse =
    { errors: Option<list<magiccreategretunnelresponseErrors>>
      messages: Option<list<magiccreategretunnelresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccreategretunnelresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiccreategretunnelresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magiccreaterouterequest =
    { ///An optional human provided description of the static route.
      description: Option<magicdescription>
      ///The next-hop IP Address for the static route.
      nexthop: magicnexthop
      ///IP Prefix in Classless Inter-Domain Routing format.
      prefix: magicprefix
      ///Priority of the static route.
      priority: magicpriority
      ///Used only for ECMP routes.
      scope: Option<magicscope>
      ///Optional weight of the ECMP scope - if provided.
      weight: Option<magicweight> }
    ///Creates an instance of magiccreaterouterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (nexthop: magicnexthop, prefix: magicprefix, priority: magicpriority): magiccreaterouterequest =
        { description = None
          nexthop = nexthop
          prefix = prefix
          priority = priority
          scope = None
          weight = None }

type magiccreaterouteresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiccreaterouteresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiccreaterouteresponseErrors =
        { code = code; message = message }

type magiccreaterouteresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiccreaterouteresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiccreaterouteresponseMessages =
        { code = code; message = message }

type magiccreaterouteresponse =
    { errors: Option<list<magiccreaterouteresponseErrors>>
      messages: Option<list<magiccreaterouteresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiccreaterouteresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiccreaterouteresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magiccustomremoteidentities =
    { ///A custom IKE ID of type FQDN that may be used to identity the IPsec tunnel. The
      ///generated IKE IDs can still be used even if this custom value is specified.
      ///Must be of the form `&amp;lt;custom label&amp;gt;.&amp;lt;account ID&amp;gt;.custom.ipsec.cloudflare.com`.
      ///This custom ID does not need to be unique. Two IPsec tunnels may have the same custom
      ///fqdn_id. However, if another IPsec tunnel has the same value then the two tunnels
      ///cannot have the same cloudflare_endpoint.
      fqdn_id: Option<string> }
    ///Creates an instance of magiccustomremoteidentities with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiccustomremoteidentities = { fqdn_id = None }

///The configuration specific to GRE interconnects.
type magicgre =
    { ///The IP address assigned to the Cloudflare side of the GRE tunnel created as part of the Interconnect.
      cloudflare_endpoint: Option<string> }
    ///Creates an instance of magicgre with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicgre = { cloudflare_endpoint = None }

type ``magicgre-tunnel`` =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      bgp_status: Option<magicbgpstatuswithstate>
      ///The IP address assigned to the Cloudflare side of the GRE tunnel.
      cloudflare_gre_endpoint: magiccloudflaregreendpoint
      ///The date and time the tunnel was created.
      created_on: Option<``magicschemas-createdon``>
      ///The IP address assigned to the customer side of the GRE tunnel.
      customer_gre_endpoint: magiccustomergreendpoint
      ///An optional description of the GRE tunnel.
      description: Option<``magicschemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///Identifier
      id: ``magicschemas-identifier``
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: magicinterfaceaddress
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The date and time the tunnel was last modified.
      modified_on: Option<``magicschemas-modifiedon``>
      ///Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.
      mtu: Option<magicmtu>
      ///The name of the tunnel. The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
      name: magicgretunnelname
      ///Time To Live (TTL) in number of hops of the GRE tunnel.
      ttl: Option<magicttl> }
    ///Creates an instance of magicgre-tunnel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloudflare_gre_endpoint: magiccloudflaregreendpoint,
                          customer_gre_endpoint: magiccustomergreendpoint,
                          id: ``magicschemas-identifier``,
                          interface_address: magicinterfaceaddress,
                          name: magicgretunnelname): ``magicgre-tunnel`` =
        { automatic_return_routing = None
          bgp = None
          bgp_status = None
          cloudflare_gre_endpoint = cloudflare_gre_endpoint
          created_on = None
          customer_gre_endpoint = customer_gre_endpoint
          description = None
          health_check = None
          id = id
          interface_address = interface_address
          interface_address6 = None
          modified_on = None
          mtu = None
          name = name
          ttl = None }

type magicgretunneladdsinglerequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      ///The IP address assigned to the Cloudflare side of the GRE tunnel.
      cloudflare_gre_endpoint: magiccloudflaregreendpoint
      ///The IP address assigned to the customer side of the GRE tunnel.
      customer_gre_endpoint: magiccustomergreendpoint
      ///An optional description of the GRE tunnel.
      description: Option<``magicschemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: magicinterfaceaddress
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.
      mtu: Option<magicmtu>
      ///The name of the tunnel. The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
      name: magicgretunnelname
      ///Time To Live (TTL) in number of hops of the GRE tunnel.
      ttl: Option<magicttl> }
    ///Creates an instance of magicgretunneladdsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloudflare_gre_endpoint: magiccloudflaregreendpoint,
                          customer_gre_endpoint: magiccustomergreendpoint,
                          interface_address: magicinterfaceaddress,
                          name: magicgretunnelname): magicgretunneladdsinglerequest =
        { automatic_return_routing = None
          cloudflare_gre_endpoint = cloudflare_gre_endpoint
          customer_gre_endpoint = customer_gre_endpoint
          description = None
          health_check = None
          interface_address = interface_address
          interface_address6 = None
          mtu = None
          name = name
          ttl = None }

type magicgretunnelupdaterequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      ///The IP address assigned to the Cloudflare side of the GRE tunnel.
      cloudflare_gre_endpoint: Option<magiccloudflaregreendpoint>
      ///The IP address assigned to the customer side of the GRE tunnel.
      customer_gre_endpoint: Option<magiccustomergreendpoint>
      ///An optional description of the GRE tunnel.
      description: Option<``magicschemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: Option<magicinterfaceaddress>
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///Maximum Transmission Unit (MTU) in bytes for the GRE tunnel. The minimum value is 576.
      mtu: Option<magicmtu>
      ///The name of the tunnel. The name cannot contain spaces or special characters, must be 15 characters or less, and cannot share a name with another GRE tunnel.
      name: Option<magicgretunnelname>
      ///Time To Live (TTL) in number of hops of the GRE tunnel.
      ttl: Option<magicttl> }
    ///Creates an instance of magicgretunnelupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicgretunnelupdaterequest =
        { automatic_return_routing = None
          cloudflare_gre_endpoint = None
          customer_gre_endpoint = None
          description = None
          health_check = None
          interface_address = None
          interface_address6 = None
          mtu = None
          name = None
          ttl = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Rate =
    | [<CompiledName "low">] Low
    | [<CompiledName "mid">] Mid
    | [<CompiledName "high">] High
    member this.Format() =
        match this with
        | Low -> "low"
        | Mid -> "mid"
        | High -> "high"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "reply">] Reply
    | [<CompiledName "request">] Request
    member this.Format() =
        match this with
        | Reply -> "reply"
        | Request -> "request"

type magichealthcheckbase =
    { ///Determines whether to run healthchecks for a tunnel.
      enabled: Option<bool>
      ///How frequent the health check is run. The default value is `mid`.
      rate: Option<Rate>
      ///The destination address in a request type health check. After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to `customer_gre_endpoint address`. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
      target: Option<Newtonsoft.Json.Linq.JToken>
      ///The type of healthcheck to run, reply or request. The default value is `reply`.
      ``type``: Option<Type> }
    ///Creates an instance of magichealthcheckbase with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magichealthcheckbase =
        { enabled = None
          rate = None
          target = None
          ``type`` = None }

///The destination address in a request type health check. After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to `customer_gre_endpoint address`. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target.
type magichealthchecktarget =
    { ///The effective health check target. If 'saved' is empty, then this field will be populated with the calculated default value on GET requests. Ignored in POST, PUT, and PATCH requests.
      effective: Option<string>
      ///The saved health check target. Setting the value to the empty string indicates that the calculated default value will be used.
      saved: Option<string> }
    ///Creates an instance of magichealthchecktarget with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magichealthchecktarget = { effective = None; saved = None }

type magicinterconnect =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      ///The name of the interconnect. The name cannot share a name with other tunnels.
      colo_name: Option<``magiccomponents-schemas-name``>
      ///The date and time the tunnel was created.
      created_on: Option<``magicschemas-createdon``>
      ///An optional description of the interconnect.
      description: Option<``magicinterconnectcomponents-schemas-description``>
      ///The configuration specific to GRE interconnects.
      gre: Option<magicgre>
      health_check: Option<magichealthcheckbase>
      ///Identifier
      id: Option<``magicschemas-identifier``>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: Option<magicinterfaceaddress>
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The date and time the tunnel was last modified.
      modified_on: Option<``magicschemas-modifiedon``>
      ///The Maximum Transmission Unit (MTU) in bytes for the interconnect. The minimum value is 576.
      mtu: Option<``magicschemas-mtu``>
      ///The name of the interconnect. The name cannot share a name with other tunnels.
      name: Option<``magiccomponents-schemas-name``> }
    ///Creates an instance of magicinterconnect with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicinterconnect =
        { automatic_return_routing = None
          colo_name = None
          created_on = None
          description = None
          gre = None
          health_check = None
          id = None
          interface_address = None
          interface_address6 = None
          modified_on = None
          mtu = None
          name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magicinterconnecthealthcheckRate =
    | [<CompiledName "low">] Low
    | [<CompiledName "mid">] Mid
    | [<CompiledName "high">] High
    member this.Format() =
        match this with
        | Low -> "low"
        | Mid -> "mid"
        | High -> "high"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magicinterconnecthealthcheckType =
    | [<CompiledName "reply">] Reply
    | [<CompiledName "request">] Request
    member this.Format() =
        match this with
        | Reply -> "reply"
        | Request -> "request"

type magicinterconnecthealthcheck =
    { ///Determines whether to run healthchecks for a tunnel.
      enabled: Option<bool>
      ///How frequent the health check is run. The default value is `mid`.
      rate: Option<magicinterconnecthealthcheckRate>
      ///The destination address in a request type health check. After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to `customer_gre_endpoint address`. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
      target: Option<Newtonsoft.Json.Linq.JToken>
      ///The type of healthcheck to run, reply or request. The default value is `reply`.
      ``type``: Option<magicinterconnecthealthcheckType> }
    ///Creates an instance of magicinterconnecthealthcheck with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicinterconnecthealthcheck =
        { enabled = None
          rate = None
          target = None
          ``type`` = None }

type magicinterconnecttunnelupdaterequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      ///An optional description of the interconnect.
      description: Option<``magicinterconnectcomponents-schemas-description``>
      ///The configuration specific to GRE interconnects.
      gre: Option<magicgre>
      health_check: Option<magichealthcheckbase>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: Option<magicinterfaceaddress>
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The Maximum Transmission Unit (MTU) in bytes for the interconnect. The minimum value is 576.
      mtu: Option<``magicschemas-mtu``> }
    ///Creates an instance of magicinterconnecttunnelupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicinterconnecttunnelupdaterequest =
        { automatic_return_routing = None
          description = None
          gre = None
          health_check = None
          interface_address = None
          interface_address6 = None
          mtu = None }

type ``magicipsec-tunnel`` =
    { ///When `true`, the tunnel can use a null-cipher (`ENCR_NULL`) in the ESP tunnel (Phase 2).
      allow_null_cipher: Option<magicallownullcipher>
      ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      bgp_status: Option<magicbgpstatuswithstate>
      ///The IP address assigned to the Cloudflare side of the IPsec tunnel.
      cloudflare_endpoint: magiccloudflareipsecendpoint
      ///The date and time the tunnel was created.
      created_on: Option<``magicschemas-createdon``>
      custom_remote_identities: Option<magiccustomremoteidentities>
      ///The IP address assigned to the customer side of the IPsec tunnel. Not required, but must be set for proactive traceroutes to work.
      customer_endpoint: Option<magiccustomeripsecendpoint>
      ///An optional description forthe IPsec tunnel.
      description: Option<``magiccomponents-schemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///Identifier
      id: ``magicschemas-identifier``
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: magicinterfaceaddress
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The date and time the tunnel was last modified.
      modified_on: Option<``magicschemas-modifiedon``>
      ///The name of the IPsec tunnel. The name cannot share a name with other tunnels.
      name: magicipsectunnelname
      ///The PSK metadata that includes when the PSK was generated.
      psk_metadata: Option<magicpskmetadata>
      ///If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.
      replay_protection: Option<magicreplayprotection> }
    ///Creates an instance of magicipsec-tunnel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloudflare_endpoint: magiccloudflareipsecendpoint,
                          id: ``magicschemas-identifier``,
                          interface_address: magicinterfaceaddress,
                          name: magicipsectunnelname): ``magicipsec-tunnel`` =
        { allow_null_cipher = None
          automatic_return_routing = None
          bgp = None
          bgp_status = None
          cloudflare_endpoint = cloudflare_endpoint
          created_on = None
          custom_remote_identities = None
          customer_endpoint = None
          description = None
          health_check = None
          id = id
          interface_address = interface_address
          interface_address6 = None
          modified_on = None
          name = name
          psk_metadata = None
          replay_protection = None }

type magicipsectunneladdrequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      ///The IP address assigned to the Cloudflare side of the IPsec tunnel.
      cloudflare_endpoint: Option<magiccloudflareipsecendpoint>
      custom_remote_identities: Option<magiccustomremoteidentities>
      ///The IP address assigned to the customer side of the IPsec tunnel. Not required, but must be set for proactive traceroutes to work.
      customer_endpoint: Option<magiccustomeripsecendpoint>
      ///An optional description forthe IPsec tunnel.
      description: Option<``magiccomponents-schemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: Option<magicinterfaceaddress>
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The name of the IPsec tunnel. The name cannot share a name with other tunnels.
      name: Option<magicipsectunnelname>
      ///A randomly generated or provided string for use in the IPsec tunnel.
      psk: Option<magicpsk>
      ///If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.
      replay_protection: Option<magicreplayprotection> }
    ///Creates an instance of magicipsectunneladdrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicipsectunneladdrequest =
        { automatic_return_routing = None
          bgp = None
          cloudflare_endpoint = None
          custom_remote_identities = None
          customer_endpoint = None
          description = None
          health_check = None
          interface_address = None
          interface_address6 = None
          name = None
          psk = None
          replay_protection = None }

type magicipsectunneladdsinglerequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      ///The IP address assigned to the Cloudflare side of the IPsec tunnel.
      cloudflare_endpoint: magiccloudflareipsecendpoint
      custom_remote_identities: Option<magiccustomremoteidentities>
      ///The IP address assigned to the customer side of the IPsec tunnel. Not required, but must be set for proactive traceroutes to work.
      customer_endpoint: Option<magiccustomeripsecendpoint>
      ///An optional description forthe IPsec tunnel.
      description: Option<``magiccomponents-schemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: magicinterfaceaddress
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The name of the IPsec tunnel. The name cannot share a name with other tunnels.
      name: magicipsectunnelname
      ///A randomly generated or provided string for use in the IPsec tunnel.
      psk: Option<magicpsk>
      ///If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.
      replay_protection: Option<magicreplayprotection> }
    ///Creates an instance of magicipsectunneladdsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloudflare_endpoint: magiccloudflareipsecendpoint,
                          interface_address: magicinterfaceaddress,
                          name: magicipsectunnelname): magicipsectunneladdsinglerequest =
        { automatic_return_routing = None
          bgp = None
          cloudflare_endpoint = cloudflare_endpoint
          custom_remote_identities = None
          customer_endpoint = None
          description = None
          health_check = None
          interface_address = interface_address
          interface_address6 = None
          name = name
          psk = None
          replay_protection = None }

type magicipsectunnelupdaterequest =
    { ///True if automatic stateful return routing should be enabled for a tunnel, false otherwise.
      automatic_return_routing: Option<magicautomaticreturnrouting>
      bgp: Option<magicbgpconfig>
      ///The IP address assigned to the Cloudflare side of the IPsec tunnel.
      cloudflare_endpoint: Option<magiccloudflareipsecendpoint>
      custom_remote_identities: Option<magiccustomremoteidentities>
      ///The IP address assigned to the customer side of the IPsec tunnel. Not required, but must be set for proactive traceroutes to work.
      customer_endpoint: Option<magiccustomeripsecendpoint>
      ///An optional description forthe IPsec tunnel.
      description: Option<``magiccomponents-schemas-description``>
      health_check: Option<Newtonsoft.Json.Linq.JToken>
      ///A 31-bit prefix (/31 in CIDR notation) supporting two hosts, one for each side of the tunnel. Select the subnet from the following private IP space: 10.0.0.0–10.255.255.255, 172.16.0.0–172.31.255.255, 192.168.0.0–192.168.255.255.
      interface_address: Option<magicinterfaceaddress>
      ///A 127 bit IPV6 prefix from within the virtual_subnet6 prefix space with the address being the first IP of the subnet and not same as the address of virtual_subnet6. Eg if virtual_subnet6 is 2606:54c1:7:0:a9fe:12d2::/127 , interface_address6 could be 2606:54c1:7:0:a9fe:12d2:1:200/127
      interface_address6: Option<magicinterfaceaddress6>
      ///The name of the IPsec tunnel. The name cannot share a name with other tunnels.
      name: Option<magicipsectunnelname>
      ///A randomly generated or provided string for use in the IPsec tunnel.
      psk: Option<magicpsk>
      ///If `true`, then IPsec replay protection will be supported in the Cloudflare-to-customer direction.
      replay_protection: Option<magicreplayprotection> }
    ///Creates an instance of magicipsectunnelupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicipsectunnelupdaterequest =
        { automatic_return_routing = None
          bgp = None
          cloudflare_endpoint = None
          custom_remote_identities = None
          customer_endpoint = None
          description = None
          health_check = None
          interface_address = None
          interface_address6 = None
          name = None
          psk = None
          replay_protection = None }

type magiclan =
    { bond_id: Option<magicbondid>
      ///mark true to use this LAN for HA probing. only works for site with HA turned on. only one LAN can be set as the ha_link.
      ha_link: Option<bool>
      ///Identifier
      id: Option<magicidentifier>
      ///mark true to use this LAN for source-based breakout traffic
      is_breakout: Option<bool>
      ///mark true to use this LAN for source-based prioritized traffic
      is_prioritized: Option<bool>
      name: Option<string>
      nat: Option<magicnat>
      physport: Option<magicport>
      routed_subnets: Option<list<magicroutedsubnet>>
      ///Identifier
      site_id: Option<magicidentifier>
      ///If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP). However, if in high availability mode, static_address is required along with secondary and virtual address.
      static_addressing: Option<magiclanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magiclan with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclan =
        { bond_id = None
          ha_link = None
          id = None
          is_breakout = None
          is_prioritized = None
          name = None
          nat = None
          physport = None
          routed_subnets = None
          site_id = None
          static_addressing = None
          vlan_tag = None }

type ``magiclan-acl-configuration`` =
    { ///The identifier for the LAN you want to create an ACL policy with.
      lan_id: string
      ///The name of the LAN based on the provided lan_id.
      lan_name: Option<string>
      ///Array of port ranges on the provided LAN that will be included in the ACL. If no ports or port rangess are provided, communication on any port on this LAN is allowed.
      port_ranges: Option<list<``magicacl-port-range``>>
      ///Array of ports on the provided LAN that will be included in the ACL. If no ports or port ranges are provided, communication on any port on this LAN is allowed.
      ports: Option<list<magicport>>
      ///Array of subnet IPs within the LAN that will be included in the ACL. If no subnets are provided, communication on any subnets on this LAN are allowed.
      subnets: Option<list<``magicacl-subnet``>> }
    ///Creates an instance of magiclan-acl-configuration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (lan_id: string): ``magiclan-acl-configuration`` =
        { lan_id = lan_id
          lan_name = None
          port_ranges = None
          ports = None
          subnets = None }

type magiclandeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiclandeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclandeletedresponseErrors =
        { code = code; message = message }

type magiclandeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiclandeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclandeletedresponseMessages =
        { code = code; message = message }

type magiclandeletedresponse =
    { errors: Option<list<magiclandeletedresponseErrors>>
      messages: Option<list<magiclandeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiclandeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclandeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magiclandhcprelay =
    { ///List of DHCP server IPs.
      server_addresses: Option<list<``magicip-address``>> }
    ///Creates an instance of magiclandhcprelay with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclandhcprelay = { server_addresses = None }

type magiclandhcpserver =
    { ///A valid IPv4 address.
      dhcp_pool_end: Option<``magicip-address``>
      ///A valid IPv4 address.
      dhcp_pool_start: Option<``magicip-address``>
      ///A valid IPv4 address.
      dns_server: Option<``magicip-address``>
      dns_servers: Option<list<``magicip-address``>>
      ///Mapping of MAC addresses to IP addresses
      reservations: Option<Map<string, string>> }
    ///Creates an instance of magiclandhcpserver with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclandhcpserver =
        { dhcp_pool_end = None
          dhcp_pool_start = None
          dns_server = None
          dns_servers = None
          reservations = None }

type magiclanmodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiclanmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclanmodifiedresponseErrors =
        { code = code; message = message }

type magiclanmodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiclanmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclanmodifiedresponseMessages =
        { code = code; message = message }

type magiclanmodifiedresponse =
    { errors: Option<list<magiclanmodifiedresponseErrors>>
      messages: Option<list<magiclanmodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiclanmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclanmodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magiclansingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiclansingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclansingleresponseErrors = { code = code; message = message }

type magiclansingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiclansingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclansingleresponseMessages =
        { code = code; message = message }

type magiclansingleresponse =
    { errors: Option<list<magiclansingleresponseErrors>>
      messages: Option<list<magiclansingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiclansingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclansingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP). However, if in high availability mode, static_address is required along with secondary and virtual address.
type magiclanstaticaddressing =
    { ///A valid CIDR notation representing an IP range.
      address: magiccidr
      dhcp_relay: Option<magiclandhcprelay>
      dhcp_server: Option<magiclandhcpserver>
      ///A valid CIDR notation representing an IP range.
      secondary_address: Option<magiccidr>
      ///A valid CIDR notation representing an IP range.
      virtual_address: Option<magiccidr> }
    ///Creates an instance of magiclanstaticaddressing with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (address: magiccidr): magiclanstaticaddressing =
        { address = address
          dhcp_relay = None
          dhcp_server = None
          secondary_address = None
          virtual_address = None }

type magiclanupdaterequest =
    { bond_id: Option<magicbondid>
      ///mark true to use this LAN for source-based breakout traffic
      is_breakout: Option<bool>
      ///mark true to use this LAN for source-based prioritized traffic
      is_prioritized: Option<bool>
      name: Option<string>
      nat: Option<magicnat>
      physport: Option<magicport>
      routed_subnets: Option<list<magicroutedsubnet>>
      ///If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP). However, if in high availability mode, static_address is required along with secondary and virtual address.
      static_addressing: Option<magiclanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magiclanupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclanupdaterequest =
        { bond_id = None
          is_breakout = None
          is_prioritized = None
          name = None
          nat = None
          physport = None
          routed_subnets = None
          static_addressing = None
          vlan_tag = None }

type magiclansaddsinglerequest =
    { bond_id: Option<magicbondid>
      ///mark true to use this LAN for HA probing. only works for site with HA turned on. only one LAN can be set as the ha_link.
      ha_link: Option<bool>
      ///mark true to use this LAN for source-based breakout traffic
      is_breakout: Option<bool>
      ///mark true to use this LAN for source-based prioritized traffic
      is_prioritized: Option<bool>
      name: Option<string>
      nat: Option<magicnat>
      physport: Option<magicport>
      routed_subnets: Option<list<magicroutedsubnet>>
      ///If the site is not configured in high availability mode, this configuration is optional (if omitted, use DHCP). However, if in high availability mode, static_address is required along with secondary and virtual address.
      static_addressing: Option<magiclanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magiclansaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclansaddsinglerequest =
        { bond_id = None
          ha_link = None
          is_breakout = None
          is_prioritized = None
          name = None
          nat = None
          physport = None
          routed_subnets = None
          static_addressing = None
          vlan_tag = None }

type magiclanscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magiclanscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclanscollectionresponseErrors =
        { code = code; message = message }

type magiclanscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magiclanscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magiclanscollectionresponseMessages =
        { code = code; message = message }

type magiclanscollectionresponse =
    { errors: Option<list<magiclanscollectionresponseErrors>>
      messages: Option<list<magiclanscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magiclanscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magiclanscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///Managed app defined by Cloudflare.
type magicmanagedapp =
    { ///FQDNs to associate with traffic decisions.
      hostnames: Option<magicapphostnames>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      ip_subnets: Option<magicappsubnets>
      ///Managed app ID.
      managed_app_id: magicmanagedappid
      ///Display name for the app.
      name: Option<magicappname>
      ///IPv4 CIDRs to associate with traffic decisions. (IPv6 CIDRs are currently unsupported)
      source_subnets: Option<magicappsourcesubnets>
      ///Category of the app.
      ``type``: Option<magicapptype> }
    ///Creates an instance of magicmanagedapp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (managed_app_id: magicmanagedappid): magicmanagedapp =
        { hostnames = None
          ip_subnets = None
          managed_app_id = managed_app_id
          name = None
          source_subnets = None
          ``type`` = None }

type magicmodifiedtunnelscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicmodifiedtunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmodifiedtunnelscollectionresponseErrors =
        { code = code; message = message }

type magicmodifiedtunnelscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicmodifiedtunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmodifiedtunnelscollectionresponseMessages =
        { code = code; message = message }

type magicmodifiedtunnelscollectionresponse =
    { errors: Option<list<magicmodifiedtunnelscollectionresponseErrors>>
      messages: Option<list<magicmodifiedtunnelscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicmodifiedtunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicmodifiedtunnelscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicmultipleroutedeleteresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicmultipleroutedeleteresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmultipleroutedeleteresponseErrors =
        { code = code; message = message }

type magicmultipleroutedeleteresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicmultipleroutedeleteresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmultipleroutedeleteresponseMessages =
        { code = code; message = message }

type magicmultipleroutedeleteresponse =
    { errors: Option<list<magicmultipleroutedeleteresponseErrors>>
      messages: Option<list<magicmultipleroutedeleteresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicmultipleroutedeleteresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicmultipleroutedeleteresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicmultipleroutemodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicmultipleroutemodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmultipleroutemodifiedresponseErrors =
        { code = code; message = message }

type magicmultipleroutemodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicmultipleroutemodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicmultipleroutemodifiedresponseMessages =
        { code = code; message = message }

type magicmultipleroutemodifiedresponse =
    { errors: Option<list<magicmultipleroutemodifiedresponseErrors>>
      messages: Option<list<magicmultipleroutemodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicmultipleroutemodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicmultipleroutemodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicnat =
    { ///A valid CIDR notation representing an IP range.
      static_prefix: Option<magiccidr> }
    ///Creates an instance of magicnat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicnat = { static_prefix = None }

///NetFlow configuration for a site.
type magicnetflowconfig =
    { ///Timeout in seconds for active flows (defaults to 30).
      active_timeout: Option<int>
      ///IPv4 address of the NetFlow collector.
      collector_ip: string
      ///UDP port of the NetFlow collector (defaults to 2055).
      collector_port: Option<int>
      ///Timeout in seconds for inactive flows (defaults to 15).
      inactive_timeout: Option<int>
      ///Sampling rate for NetFlow records (1 = every packet, 1000 = 1 in 1000 packets). Defaults to 1.
      sampling_rate: Option<int> }
    ///Creates an instance of magicnetflowconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (collector_ip: string): magicnetflowconfig =
        { active_timeout = None
          collector_ip = collector_ip
          collector_port = None
          inactive_timeout = None
          sampling_rate = None }

type magicnetflowconfigrequest =
    { ///Timeout in seconds for active flows.
      active_timeout: Option<int>
      ///IPv4 address of the NetFlow collector.
      collector_ip: Option<string>
      ///UDP port of the NetFlow collector.
      collector_port: Option<int>
      ///Timeout in seconds for inactive flows.
      inactive_timeout: Option<int>
      ///Sampling rate for NetFlow records (1 = every packet).
      sampling_rate: Option<int> }
    ///Creates an instance of magicnetflowconfigrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicnetflowconfigrequest =
        { active_timeout = None
          collector_ip = None
          collector_port = None
          inactive_timeout = None
          sampling_rate = None }

type magicnetflowconfigsingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicnetflowconfigsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicnetflowconfigsingleresponseErrors =
        { code = code; message = message }

type magicnetflowconfigsingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicnetflowconfigsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicnetflowconfigsingleresponseMessages =
        { code = code; message = message }

type magicnetflowconfigsingleresponse =
    { errors: Option<list<magicnetflowconfigsingleresponseErrors>>
      messages: Option<list<magicnetflowconfigsingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicnetflowconfigsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicnetflowconfigsingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicpskgenerationresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicpskgenerationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicpskgenerationresponseErrors =
        { code = code; message = message }

type magicpskgenerationresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicpskgenerationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicpskgenerationresponseMessages =
        { code = code; message = message }

type magicpskgenerationresponse =
    { errors: Option<list<magicpskgenerationresponseErrors>>
      messages: Option<list<magicpskgenerationresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicpskgenerationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicpskgenerationresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///The PSK metadata that includes when the PSK was generated.
type magicpskmetadata =
    { ///The date and time the tunnel was last modified.
      last_generated_on: Option<``magicschemas-modifiedon``> }
    ///Creates an instance of magicpskmetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicpskmetadata = { last_generated_on = None }

type magicroute =
    { ///When the route was created.
      created_on: Option<magiccreatedon>
      ///An optional human provided description of the static route.
      description: Option<magicdescription>
      ///Identifier
      id: magicidentifier
      ///When the route was last modified.
      modified_on: Option<magicmodifiedon>
      ///The next-hop IP Address for the static route.
      nexthop: magicnexthop
      ///IP Prefix in Classless Inter-Domain Routing format.
      prefix: magicprefix
      ///Priority of the static route.
      priority: magicpriority
      ///Used only for ECMP routes.
      scope: Option<magicscope>
      ///Optional weight of the ECMP scope - if provided.
      weight: Option<magicweight> }
    ///Creates an instance of magicroute with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: magicidentifier, nexthop: magicnexthop, prefix: magicprefix, priority: magicpriority): magicroute =
        { created_on = None
          description = None
          id = id
          modified_on = None
          nexthop = nexthop
          prefix = prefix
          priority = priority
          scope = None
          weight = None }

type magicrouteaddsinglerequest =
    { ///An optional human provided description of the static route.
      description: Option<magicdescription>
      ///The next-hop IP Address for the static route.
      nexthop: magicnexthop
      ///IP Prefix in Classless Inter-Domain Routing format.
      prefix: magicprefix
      ///Priority of the static route.
      priority: magicpriority
      ///Used only for ECMP routes.
      scope: Option<magicscope>
      ///Optional weight of the ECMP scope - if provided.
      weight: Option<magicweight> }
    ///Creates an instance of magicrouteaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (nexthop: magicnexthop, prefix: magicprefix, priority: magicpriority): magicrouteaddsinglerequest =
        { description = None
          nexthop = nexthop
          prefix = prefix
          priority = priority
          scope = None
          weight = None }

type magicroutedeleteid =
    { ///Identifier
      id: Option<magicidentifier> }
    ///Creates an instance of magicroutedeleteid with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutedeleteid = { id = None }

type magicroutedeletemanyrequest =
    { routes: list<magicroutedeleteid> }
    ///Creates an instance of magicroutedeletemanyrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (routes: list<magicroutedeleteid>): magicroutedeletemanyrequest = { routes = routes }

type magicroutedeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicroutedeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutedeletedresponseErrors =
        { code = code; message = message }

type magicroutedeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicroutedeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutedeletedresponseMessages =
        { code = code; message = message }

type magicroutedeletedresponseResult =
    { deleted: Option<bool>
      deleted_route: Option<magicroute> }
    ///Creates an instance of magicroutedeletedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutedeletedresponseResult = { deleted = None; deleted_route = None }

type magicroutedeletedresponse =
    { errors: Option<list<magicroutedeletedresponseErrors>>
      messages: Option<list<magicroutedeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicroutedeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutedeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicroutemodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicroutemodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutemodifiedresponseErrors =
        { code = code; message = message }

type magicroutemodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicroutemodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutemodifiedresponseMessages =
        { code = code; message = message }

type magicroutemodifiedresponseResult =
    { modified: Option<bool>
      modified_route: Option<magicroute> }
    ///Creates an instance of magicroutemodifiedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutemodifiedresponseResult =
        { modified = None
          modified_route = None }

type magicroutemodifiedresponse =
    { errors: Option<list<magicroutemodifiedresponseErrors>>
      messages: Option<list<magicroutemodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicroutemodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutemodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicroutesingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicroutesingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutesingleresponseErrors =
        { code = code; message = message }

type magicroutesingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicroutesingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutesingleresponseMessages =
        { code = code; message = message }

type magicroutesingleresponseResult =
    { route: Option<magicroute> }
    ///Creates an instance of magicroutesingleresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutesingleresponseResult = { route = None }

type magicroutesingleresponse =
    { errors: Option<list<magicroutesingleresponseErrors>>
      messages: Option<list<magicroutesingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicroutesingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutesingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicrouteupdatemanyrequest =
    { routes: list<magicrouteupdatesinglerequest> }
    ///Creates an instance of magicrouteupdatemanyrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (routes: list<magicrouteupdatesinglerequest>): magicrouteupdatemanyrequest =
        { routes = routes }

type magicrouteupdaterequest =
    { ///An optional human provided description of the static route.
      description: Option<magicdescription>
      ///The next-hop IP Address for the static route.
      nexthop: Option<magicnexthop>
      ///IP Prefix in Classless Inter-Domain Routing format.
      prefix: Option<magicprefix>
      ///Priority of the static route.
      priority: Option<magicpriority>
      ///Used only for ECMP routes.
      scope: Option<magicscope>
      ///Optional weight of the ECMP scope - if provided.
      weight: Option<magicweight> }
    ///Creates an instance of magicrouteupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicrouteupdaterequest =
        { description = None
          nexthop = None
          prefix = None
          priority = None
          scope = None
          weight = None }

type magicrouteupdatesinglerequest =
    { ///Identifier
      id: Option<magicidentifier>
      ///An optional human provided description of the static route.
      description: Option<magicdescription>
      ///The next-hop IP Address for the static route.
      nexthop: Option<magicnexthop>
      ///IP Prefix in Classless Inter-Domain Routing format.
      prefix: Option<magicprefix>
      ///Priority of the static route.
      priority: Option<magicpriority>
      ///Used only for ECMP routes.
      scope: Option<magicscope>
      ///Optional weight of the ECMP scope - if provided.
      weight: Option<magicweight> }
    ///Creates an instance of magicrouteupdatesinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicrouteupdatesinglerequest =
        { id = None
          description = None
          nexthop = None
          prefix = None
          priority = None
          scope = None
          weight = None }

type magicroutedsubnet =
    { nat: Option<magicnat>
      ///A valid IPv4 address.
      next_hop: ``magicip-address``
      ///A valid CIDR notation representing an IP range.
      prefix: magiccidr }
    ///Creates an instance of magicroutedsubnet with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (next_hop: ``magicip-address``, prefix: magiccidr): magicroutedsubnet =
        { nat = None
          next_hop = next_hop
          prefix = prefix }

type magicroutescollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicroutescollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutescollectionresponseErrors =
        { code = code; message = message }

type magicroutescollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicroutescollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicroutescollectionresponseMessages =
        { code = code; message = message }

type magicroutescollectionresponse =
    { errors: Option<list<magicroutescollectionresponseErrors>>
      messages: Option<list<magicroutescollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicroutescollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicroutescollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-createipsectunnelresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-createipsectunnelresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-createipsectunnelresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-createipsectunnelresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-createipsectunnelresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-createipsectunnelresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-createipsectunnelresponse`` =
    { errors: Option<list<``magicschemas-createipsectunnelresponseErrors``>>
      messages: Option<list<``magicschemas-createipsectunnelresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-createipsectunnelresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-createipsectunnelresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-modifiedtunnelscollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-modifiedtunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-modifiedtunnelscollectionresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-modifiedtunnelscollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-modifiedtunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-modifiedtunnelscollectionresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-modifiedtunnelscollectionresponse`` =
    { errors: Option<list<``magicschemas-modifiedtunnelscollectionresponseErrors``>>
      messages: Option<list<``magicschemas-modifiedtunnelscollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-modifiedtunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-modifiedtunnelscollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-tunneldeletedresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunneldeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunneldeletedresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-tunneldeletedresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunneldeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunneldeletedresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-tunneldeletedresponseResult`` =
    { deleted: Option<bool>
      deleted_ipsec_tunnel: Option<``magicipsec-tunnel``> }
    ///Creates an instance of magicschemas-tunneldeletedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunneldeletedresponseResult`` =
        { deleted = None
          deleted_ipsec_tunnel = None }

type ``magicschemas-tunneldeletedresponse`` =
    { errors: Option<list<``magicschemas-tunneldeletedresponseErrors``>>
      messages: Option<list<``magicschemas-tunneldeletedresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-tunneldeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunneldeletedresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-tunnelmodifiedresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelmodifiedresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-tunnelmodifiedresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelmodifiedresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-tunnelmodifiedresponseResult`` =
    { modified: Option<bool>
      modified_ipsec_tunnel: Option<``magicipsec-tunnel``> }
    ///Creates an instance of magicschemas-tunnelmodifiedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunnelmodifiedresponseResult`` =
        { modified = None
          modified_ipsec_tunnel = None }

type ``magicschemas-tunnelmodifiedresponse`` =
    { errors: Option<list<``magicschemas-tunnelmodifiedresponseErrors``>>
      messages: Option<list<``magicschemas-tunnelmodifiedresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-tunnelmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunnelmodifiedresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-tunnelsingleresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelsingleresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-tunnelsingleresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelsingleresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-tunnelsingleresponseResult`` =
    { ipsec_tunnel: Option<``magicipsec-tunnel``> }
    ///Creates an instance of magicschemas-tunnelsingleresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunnelsingleresponseResult`` = { ipsec_tunnel = None }

type ``magicschemas-tunnelsingleresponse`` =
    { errors: Option<list<``magicschemas-tunnelsingleresponseErrors``>>
      messages: Option<list<``magicschemas-tunnelsingleresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-tunnelsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunnelsingleresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``magicschemas-tunnelscollectionresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelscollectionresponseErrors`` =
        { code = code; message = message }

type ``magicschemas-tunnelscollectionresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of magicschemas-tunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``magicschemas-tunnelscollectionresponseMessages`` =
        { code = code; message = message }

type ``magicschemas-tunnelscollectionresponse`` =
    { errors: Option<list<``magicschemas-tunnelscollectionresponseErrors``>>
      messages: Option<list<``magicschemas-tunnelscollectionresponseMessages``>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicschemas-tunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicschemas-tunnelscollectionresponse`` =
        { errors = None
          messages = None
          result = None
          success = None }

///Used only for ECMP routes.
type magicscope =
    { ///List of colo names for the ECMP scope.
      colo_names: Option<magiccolonames>
      ///List of colo regions for the ECMP scope.
      colo_regions: Option<magiccoloregions> }
    ///Creates an instance of magicscope with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicscope =
        { colo_names = None
          colo_regions = None }

type magicsite =
    { ///Magic Connector identifier tag.
      connector_id: Option<``magicconnector-id``>
      description: Option<string>
      ///Site high availability mode. If set to true, the site can have two connectors and runs in high availability mode.
      ha_mode: Option<bool>
      ///Identifier
      id: Option<magicidentifier>
      ///Location of site in latitude and longitude.
      location: Option<``magicsite-location``>
      ///The name of the site.
      name: Option<``magicsite-name``>
      ///Magic Connector identifier tag. Used when high availability mode is on.
      secondary_connector_id: Option<``magicsecondary-connector-id``> }
    ///Creates an instance of magicsite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsite =
        { connector_id = None
          description = None
          ha_mode = None
          id = None
          location = None
          name = None
          secondary_connector_id = None }

///Location of site in latitude and longitude.
type ``magicsite-location`` =
    { ///Latitude
      lat: Option<string>
      ///Longitude
      lon: Option<string> }
    ///Creates an instance of magicsite-location with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``magicsite-location`` = { lat = None; lon = None }

type magicsitedeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicsitedeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitedeletedresponseErrors =
        { code = code; message = message }

type magicsitedeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicsitedeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitedeletedresponseMessages =
        { code = code; message = message }

type magicsitedeletedresponse =
    { errors: Option<list<magicsitedeletedresponseErrors>>
      messages: Option<list<magicsitedeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicsitedeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsitedeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicsitemodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicsitemodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitemodifiedresponseErrors =
        { code = code; message = message }

type magicsitemodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicsitemodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitemodifiedresponseMessages =
        { code = code; message = message }

type magicsitemodifiedresponse =
    { errors: Option<list<magicsitemodifiedresponseErrors>>
      messages: Option<list<magicsitemodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicsitemodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsitemodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicsitesingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicsitesingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitesingleresponseErrors =
        { code = code; message = message }

type magicsitesingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicsitesingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitesingleresponseMessages =
        { code = code; message = message }

type magicsitesingleresponse =
    { errors: Option<list<magicsitesingleresponseErrors>>
      messages: Option<list<magicsitesingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicsitesingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsitesingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicsiteupdaterequest =
    { ///Magic Connector identifier tag.
      connector_id: Option<``magicconnector-id``>
      description: Option<string>
      ///Location of site in latitude and longitude.
      location: Option<``magicsite-location``>
      ///The name of the site.
      name: Option<``magicsite-name``>
      ///Magic Connector identifier tag. Used when high availability mode is on.
      secondary_connector_id: Option<``magicsecondary-connector-id``> }
    ///Creates an instance of magicsiteupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsiteupdaterequest =
        { connector_id = None
          description = None
          location = None
          name = None
          secondary_connector_id = None }

type magicsitesaddsinglerequest =
    { ///Magic Connector identifier tag.
      connector_id: Option<``magicconnector-id``>
      description: Option<string>
      ///Site high availability mode. If set to true, the site can have two connectors and runs in high availability mode.
      ha_mode: Option<bool>
      ///Location of site in latitude and longitude.
      location: Option<``magicsite-location``>
      ///The name of the site.
      name: ``magicsite-name``
      ///Magic Connector identifier tag. Used when high availability mode is on.
      secondary_connector_id: Option<``magicsecondary-connector-id``> }
    ///Creates an instance of magicsitesaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: ``magicsite-name``): magicsitesaddsinglerequest =
        { connector_id = None
          description = None
          ha_mode = None
          location = None
          name = name
          secondary_connector_id = None }

type magicsitescollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicsitescollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitescollectionresponseErrors =
        { code = code; message = message }

type magicsitescollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicsitescollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicsitescollectionresponseMessages =
        { code = code; message = message }

type magicsitescollectionresponse =
    { errors: Option<list<magicsitescollectionresponseErrors>>
      messages: Option<list<magicsitescollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicsitescollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicsitescollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magictunneldeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magictunneldeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunneldeletedresponseErrors =
        { code = code; message = message }

type magictunneldeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magictunneldeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunneldeletedresponseMessages =
        { code = code; message = message }

type magictunneldeletedresponseResult =
    { deleted: Option<bool>
      deleted_gre_tunnel: Option<``magicgre-tunnel``> }
    ///Creates an instance of magictunneldeletedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunneldeletedresponseResult =
        { deleted = None
          deleted_gre_tunnel = None }

type magictunneldeletedresponse =
    { errors: Option<list<magictunneldeletedresponseErrors>>
      messages: Option<list<magictunneldeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magictunneldeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunneldeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magictunnelhealthcheckRate =
    | [<CompiledName "low">] Low
    | [<CompiledName "mid">] Mid
    | [<CompiledName "high">] High
    member this.Format() =
        match this with
        | Low -> "low"
        | Mid -> "mid"
        | High -> "high"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type magictunnelhealthcheckType =
    | [<CompiledName "reply">] Reply
    | [<CompiledName "request">] Request
    member this.Format() =
        match this with
        | Reply -> "reply"
        | Request -> "request"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Direction =
    | [<CompiledName "unidirectional">] Unidirectional
    | [<CompiledName "bidirectional">] Bidirectional
    member this.Format() =
        match this with
        | Unidirectional -> "unidirectional"
        | Bidirectional -> "bidirectional"

type magictunnelhealthcheck =
    { ///Determines whether to run healthchecks for a tunnel.
      enabled: Option<bool>
      ///How frequent the health check is run. The default value is `mid`.
      rate: Option<magictunnelhealthcheckRate>
      ///The destination address in a request type health check. After the healthcheck is decapsulated at the customer end of the tunnel, the ICMP echo will be forwarded to this address. This field defaults to `customer_gre_endpoint address`. This field is ignored for bidirectional healthchecks as the interface_address (not assigned to the Cloudflare side of the tunnel) is used as the target. Must be in object form if the x-magic-new-hc-target header is set to true and string form if x-magic-new-hc-target is absent or set to false.
      target: Option<Newtonsoft.Json.Linq.JToken>
      ///The type of healthcheck to run, reply or request. The default value is `reply`.
      ``type``: Option<magictunnelhealthcheckType>
      ///The direction of the flow of the healthcheck. Either unidirectional, where the probe comes to you via the tunnel and the result comes back to Cloudflare via the open Internet, or bidirectional where both the probe and result come and go via the tunnel.
      direction: Option<Direction> }
    ///Creates an instance of magictunnelhealthcheck with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelhealthcheck =
        { enabled = None
          rate = None
          target = None
          ``type`` = None
          direction = None }

type magictunnelmodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magictunnelmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelmodifiedresponseErrors =
        { code = code; message = message }

type magictunnelmodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magictunnelmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelmodifiedresponseMessages =
        { code = code; message = message }

type magictunnelmodifiedresponseResult =
    { modified: Option<bool>
      modified_gre_tunnel: Option<``magicgre-tunnel``> }
    ///Creates an instance of magictunnelmodifiedresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelmodifiedresponseResult =
        { modified = None
          modified_gre_tunnel = None }

type magictunnelmodifiedresponse =
    { errors: Option<list<magictunnelmodifiedresponseErrors>>
      messages: Option<list<magictunnelmodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magictunnelmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelmodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magictunnelsingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magictunnelsingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelsingleresponseErrors =
        { code = code; message = message }

type magictunnelsingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magictunnelsingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelsingleresponseMessages =
        { code = code; message = message }

type magictunnelsingleresponseResult =
    { gre_tunnel: Option<``magicgre-tunnel``> }
    ///Creates an instance of magictunnelsingleresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelsingleresponseResult = { gre_tunnel = None }

type magictunnelsingleresponse =
    { errors: Option<list<magictunnelsingleresponseErrors>>
      messages: Option<list<magictunnelsingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magictunnelsingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelsingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magictunnelscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magictunnelscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelscollectionresponseErrors =
        { code = code; message = message }

type magictunnelscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magictunnelscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magictunnelscollectionresponseMessages =
        { code = code; message = message }

type magictunnelscollectionresponse =
    { errors: Option<list<magictunnelscollectionresponseErrors>>
      messages: Option<list<magictunnelscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magictunnelscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magictunnelscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Healthcheckrate =
    | [<CompiledName "low">] Low
    | [<CompiledName "mid">] Mid
    | [<CompiledName "high">] High
    member this.Format() =
        match this with
        | Low -> "low"
        | Mid -> "mid"
        | High -> "high"

type magicwan =
    { ///Magic WAN health check rate for tunnels created on this link. The default value is `mid`.
      health_check_rate: Option<Healthcheckrate>
      ///Identifier
      id: Option<magicidentifier>
      name: Option<string>
      physport: Option<magicport>
      ///Priority of WAN for traffic loadbalancing.
      priority: Option<int>
      ///Identifier
      site_id: Option<magicidentifier>
      ///(optional) if omitted, use DHCP. Submit secondary_address when site is in high availability mode.
      static_addressing: Option<magicwanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magicwan with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwan =
        { health_check_rate = None
          id = None
          name = None
          physport = None
          priority = None
          site_id = None
          static_addressing = None
          vlan_tag = None }

type magicwandeletedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicwandeletedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwandeletedresponseErrors =
        { code = code; message = message }

type magicwandeletedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicwandeletedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwandeletedresponseMessages =
        { code = code; message = message }

type magicwandeletedresponse =
    { errors: Option<list<magicwandeletedresponseErrors>>
      messages: Option<list<magicwandeletedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicwandeletedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwandeletedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicwanmodifiedresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicwanmodifiedresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwanmodifiedresponseErrors =
        { code = code; message = message }

type magicwanmodifiedresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicwanmodifiedresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwanmodifiedresponseMessages =
        { code = code; message = message }

type magicwanmodifiedresponse =
    { errors: Option<list<magicwanmodifiedresponseErrors>>
      messages: Option<list<magicwanmodifiedresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicwanmodifiedresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwanmodifiedresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type magicwansingleresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicwansingleresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwansingleresponseErrors = { code = code; message = message }

type magicwansingleresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicwansingleresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwansingleresponseMessages =
        { code = code; message = message }

type magicwansingleresponse =
    { errors: Option<list<magicwansingleresponseErrors>>
      messages: Option<list<magicwansingleresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicwansingleresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwansingleresponse =
        { errors = None
          messages = None
          result = None
          success = None }

///(optional) if omitted, use DHCP. Submit secondary_address when site is in high availability mode.
type magicwanstaticaddressing =
    { ///A valid CIDR notation representing an IP range.
      address: magiccidr
      ///A valid IPv4 address.
      gateway_address: ``magicip-address``
      ///A valid CIDR notation representing an IP range.
      secondary_address: Option<magiccidr> }
    ///Creates an instance of magicwanstaticaddressing with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (address: magiccidr, gateway_address: ``magicip-address``): magicwanstaticaddressing =
        { address = address
          gateway_address = gateway_address
          secondary_address = None }

type magicwanupdaterequest =
    { name: Option<string>
      physport: Option<magicport>
      priority: Option<int>
      ///(optional) if omitted, use DHCP. Submit secondary_address when site is in high availability mode.
      static_addressing: Option<magicwanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magicwanupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwanupdaterequest =
        { name = None
          physport = None
          priority = None
          static_addressing = None
          vlan_tag = None }

type magicwansaddsinglerequest =
    { name: Option<string>
      physport: magicport
      priority: Option<int>
      ///(optional) if omitted, use DHCP. Submit secondary_address when site is in high availability mode.
      static_addressing: Option<magicwanstaticaddressing>
      ///VLAN ID. Use zero for untagged.
      vlan_tag: Option<magicvlantag> }
    ///Creates an instance of magicwansaddsinglerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (physport: magicport): magicwansaddsinglerequest =
        { name = None
          physport = physport
          priority = None
          static_addressing = None
          vlan_tag = None }

type magicwanscollectionresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of magicwanscollectionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwanscollectionresponseErrors =
        { code = code; message = message }

type magicwanscollectionresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of magicwanscollectionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): magicwanscollectionresponseMessages =
        { code = code; message = message }

type magicwanscollectionresponse =
    { errors: Option<list<magicwanscollectionresponseErrors>>
      messages: Option<list<magicwanscollectionresponseMessages>>
      result: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of magicwanscollectionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): magicwanscollectionresponse =
        { errors = None
          messages = None
          result = None
          success = None }

type mcnapplyprogress =
    { ``done``: int
      total: int }
    ///Creates an instance of mcnapplyprogress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``done``: int, total: int): mcnapplyprogress = { ``done`` = ``done``; total = total }

type mcnawstrustpolicy =
    { aws_trust_policy: string
      item_type: string }
    ///Creates an instance of mcnawstrustpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (aws_trust_policy: string, item_type: string): mcnawstrustpolicy =
        { aws_trust_policy = aws_trust_policy
          item_type = item_type }

type mcnazuresetup =
    { azure_consent_url: string
      integration_identity_tag: string
      item_type: string
      tag_cli_command: string }
    ///Creates an instance of mcnazuresetup with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (azure_consent_url: string,
                          integration_identity_tag: string,
                          item_type: string,
                          tag_cli_command: string): mcnazuresetup =
        { azure_consent_url = azure_consent_url
          integration_identity_tag = integration_identity_tag
          item_type = item_type
          tag_cli_command = tag_cli_command }

type mcnbadresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of mcnbadresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnbadresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcncatalogsync =
    { description: string
      destination_id: mcncatalogsyncdestinationid
      destination_type: mcncatalogsyncdestinationtype
      errors: Option<Map<string, mcnerror>>
      id: mcncatalogsyncid
      includes_discoveries_until: Option<string>
      last_attempted_update_at: Option<string>
      last_successful_update_at: Option<string>
      last_user_update_at: string
      name: string
      policy: string
      update_mode: mcncatalogsyncupdatemode }
    ///Creates an instance of mcncatalogsync with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: string,
                          destination_id: mcncatalogsyncdestinationid,
                          destination_type: mcncatalogsyncdestinationtype,
                          id: mcncatalogsyncid,
                          last_user_update_at: string,
                          name: string,
                          policy: string,
                          update_mode: mcncatalogsyncupdatemode): mcncatalogsync =
        { description = description
          destination_id = destination_id
          destination_type = destination_type
          errors = None
          id = id
          includes_discoveries_until = None
          last_attempted_update_at = None
          last_successful_update_at = None
          last_user_update_at = last_user_update_at
          name = name
          policy = policy
          update_mode = update_mode }

type mcncatalogsyncsprebuiltpoliciesresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<list<mcncatalogsyncsprebuiltpolicy>> }
    ///Creates an instance of mcncatalogsyncsprebuiltpoliciesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcncatalogsyncsprebuiltpoliciesresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcncatalogsyncsprebuiltpolicy =
    { applicable_destinations: list<mcncatalogsyncdestinationtype>
      policy_description: string
      policy_name: string
      policy_string: string }
    ///Creates an instance of mcncatalogsyncsprebuiltpolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (applicable_destinations: list<mcncatalogsyncdestinationtype>,
                          policy_description: string,
                          policy_name: string,
                          policy_string: string): mcncatalogsyncsprebuiltpolicy =
        { applicable_destinations = applicable_destinations
          policy_description = policy_description
          policy_name = policy_name
          policy_string = policy_string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Clienttype =
    | [<CompiledName "MAGIC_WAN_CLOUD_ONRAMP">] MAGIC_WAN_CLOUD_ONRAMP
    member this.Format() =
        match this with
        | MAGIC_WAN_CLOUD_ONRAMP -> "MAGIC_WAN_CLOUD_ONRAMP"

type mcncloudplatformclient =
    { client_type: Clienttype
      id: mcnplatformclientid
      name: string }
    ///Creates an instance of mcncloudplatformclient with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (client_type: Clienttype, id: mcnplatformclientid, name: string): mcncloudplatformclient =
        { client_type = client_type
          id = id
          name = name }

type mcncost =
    { currency: string
      monthly_cost: float }
    ///Creates an instance of mcncost with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (currency: string, monthly_cost: float): mcncost =
        { currency = currency
          monthly_cost = monthly_cost }

type mcncostdiff =
    { currency: string
      current_monthly_cost: float
      diff: float
      proposed_monthly_cost: float }
    ///Creates an instance of mcncostdiff with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (currency: string, current_monthly_cost: float, diff: float, proposed_monthly_cost: float): mcncostdiff =
        { currency = currency
          current_monthly_cost = current_monthly_cost
          diff = diff
          proposed_monthly_cost = proposed_monthly_cost }

type mcncreatecatalogsyncrequest =
    { description: Option<string>
      destination_type: mcncatalogsyncdestinationtype
      name: string
      policy: Option<string>
      update_mode: mcncatalogsyncupdatemode }
    ///Creates an instance of mcncreatecatalogsyncrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination_type: mcncatalogsyncdestinationtype,
                          name: string,
                          update_mode: mcncatalogsyncupdatemode): mcncreatecatalogsyncrequest =
        { description = None
          destination_type = destination_type
          name = name
          policy = None
          update_mode = update_mode }

type mcncreatecatalogsyncresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcncatalogsync> }
    ///Creates an instance of mcncreatecatalogsyncresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcncreatecatalogsyncresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcncreateonramprequest =
    { adopted_hub_id: Option<mcnresourceid>
      attached_hubs: Option<list<mcnresourceid>>
      attached_vpcs: Option<list<mcnresourceid>>
      ///Sets the cloud-side ASN. If unset or zero, the cloud's default ASN takes effect.
      cloud_asn: Option<int>
      cloud_type: mcnonrampcloudtype
      description: Option<string>
      ///Enables BGP routing. When enabling this feature, set both install_routes_in_cloud and install_routes_in_magic_wan to false.
      dynamic_routing: bool
      hub_provider_id: Option<mcnproviderid>
      install_routes_in_cloud: bool
      install_routes_in_magic_wan: bool
      manage_hub_to_hub_attachments: Option<bool>
      manage_vpc_to_hub_attachments: Option<bool>
      name: string
      region: Option<string>
      ``type``: mcnonramptype
      vpc: Option<mcnresourceid> }
    ///Creates an instance of mcncreateonramprequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloud_type: mcnonrampcloudtype,
                          dynamic_routing: bool,
                          install_routes_in_cloud: bool,
                          install_routes_in_magic_wan: bool,
                          name: string,
                          ``type``: mcnonramptype): mcncreateonramprequest =
        { adopted_hub_id = None
          attached_hubs = None
          attached_vpcs = None
          cloud_asn = None
          cloud_type = cloud_type
          description = None
          dynamic_routing = dynamic_routing
          hub_provider_id = None
          install_routes_in_cloud = install_routes_in_cloud
          install_routes_in_magic_wan = install_routes_in_magic_wan
          manage_hub_to_hub_attachments = None
          manage_vpc_to_hub_attachments = None
          name = name
          region = None
          ``type`` = ``type``
          vpc = None }

type mcncreateonrampresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnonramp> }
    ///Creates an instance of mcncreateonrampresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcncreateonrampresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcncreateproviderrequest =
    { cloud_type: mcncloudtype
      description: Option<string>
      friendly_name: string }
    ///Creates an instance of mcncreateproviderrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloud_type: mcncloudtype, friendly_name: string): mcncreateproviderrequest =
        { cloud_type = cloud_type
          description = None
          friendly_name = friendly_name }

type mcncreateproviderresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnprovider> }
    ///Creates an instance of mcncreateproviderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcncreateproviderresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcndeletecatalogsyncresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcndeletedcatalogsync> }
    ///Creates an instance of mcndeletecatalogsyncresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcndeletecatalogsyncresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcndeleteonrampresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcndeletedonramp> }
    ///Creates an instance of mcndeleteonrampresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcndeleteonrampresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcndeleteproviderresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcndeletedprovider> }
    ///Creates an instance of mcndeleteproviderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcndeleteproviderresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcndeletedcatalogsync =
    { id: mcncatalogsyncid }
    ///Creates an instance of mcndeletedcatalogsync with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: mcncatalogsyncid): mcndeletedcatalogsync = { id = id }

type mcndeletedonramp =
    { id: mcnonrampid }
    ///Creates an instance of mcndeletedonramp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: mcnonrampid): mcndeletedonramp = { id = id }

type mcndeletedprovider =
    { id: mcnproviderid }
    ///Creates an instance of mcndeletedprovider with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: mcnproviderid): mcndeletedprovider = { id = id }

[<RequireQualifiedAccess>]
type Code =
    | Code1001 = 1001
    | Code1002 = 1002
    | Code1003 = 1003
    | Code1004 = 1004
    | Code1005 = 1005
    | Code1006 = 1006
    | Code1007 = 1007
    | Code1008 = 1008
    | Code1009 = 1009
    | Code1010 = 1010
    | Code1011 = 1011
    | Code1012 = 1012
    | Code1013 = 1013
    | Code1014 = 1014
    | Code1015 = 1015
    | Code1016 = 1016
    | Code1017 = 1017
    | Code1018 = 1018
    | Code2001 = 2001
    | Code2002 = 2002
    | Code2003 = 2003
    | Code2004 = 2004
    | Code2005 = 2005
    | Code2006 = 2006
    | Code2007 = 2007
    | Code2008 = 2008
    | Code2009 = 2009
    | Code2010 = 2010
    | Code2011 = 2011
    | Code2012 = 2012
    | Code2013 = 2013
    | Code2014 = 2014
    | Code2015 = 2015
    | Code2016 = 2016
    | Code2017 = 2017
    | Code2018 = 2018
    | Code2019 = 2019
    | Code2020 = 2020
    | Code2021 = 2021
    | Code2022 = 2022
    | Code3001 = 3001
    | Code3002 = 3002
    | Code3003 = 3003
    | Code3004 = 3004
    | Code3005 = 3005
    | Code3006 = 3006
    | Code3007 = 3007
    | Code4001 = 4001
    | Code4002 = 4002
    | Code4003 = 4003
    | Code4004 = 4004
    | Code4005 = 4005
    | Code4006 = 4006
    | Code4007 = 4007
    | Code4008 = 4008
    | Code4009 = 4009
    | Code4010 = 4010
    | Code4011 = 4011
    | Code4012 = 4012
    | Code4013 = 4013
    | Code4014 = 4014
    | Code4015 = 4015
    | Code4016 = 4016
    | Code4017 = 4017
    | Code4018 = 4018
    | Code4019 = 4019
    | Code4020 = 4020
    | Code4021 = 4021
    | Code4022 = 4022
    | Code4023 = 4023
    | Code5001 = 5001
    | Code5002 = 5002
    | Code5003 = 5003
    | Code5004 = 5004
    | Code102000 = 102000
    | Code102001 = 102001
    | Code102002 = 102002
    | Code102003 = 102003
    | Code102004 = 102004
    | Code102005 = 102005
    | Code102006 = 102006
    | Code102007 = 102007
    | Code102008 = 102008
    | Code102009 = 102009
    | Code102010 = 102010
    | Code102011 = 102011
    | Code102012 = 102012
    | Code102013 = 102013
    | Code102014 = 102014
    | Code102015 = 102015
    | Code102016 = 102016
    | Code102017 = 102017
    | Code102018 = 102018
    | Code102019 = 102019
    | Code102020 = 102020
    | Code102021 = 102021
    | Code102022 = 102022
    | Code102023 = 102023
    | Code102024 = 102024
    | Code102025 = 102025
    | Code102026 = 102026
    | Code102027 = 102027
    | Code102028 = 102028
    | Code102029 = 102029
    | Code102030 = 102030
    | Code102031 = 102031
    | Code102032 = 102032
    | Code102033 = 102033
    | Code102034 = 102034
    | Code102035 = 102035
    | Code102036 = 102036
    | Code102037 = 102037
    | Code102038 = 102038
    | Code102039 = 102039
    | Code102040 = 102040
    | Code102041 = 102041
    | Code102042 = 102042
    | Code102043 = 102043
    | Code102044 = 102044
    | Code102045 = 102045
    | Code102046 = 102046
    | Code102047 = 102047
    | Code102048 = 102048
    | Code102049 = 102049
    | Code102050 = 102050
    | Code102051 = 102051
    | Code102052 = 102052
    | Code102053 = 102053
    | Code102054 = 102054
    | Code102055 = 102055
    | Code102056 = 102056
    | Code102057 = 102057
    | Code102058 = 102058
    | Code102059 = 102059
    | Code102060 = 102060
    | Code102061 = 102061
    | Code102062 = 102062
    | Code102063 = 102063
    | Code102064 = 102064
    | Code102065 = 102065
    | Code102066 = 102066
    | Code102067 = 102067
    | Code102068 = 102068
    | Code102069 = 102069
    | Code102070 = 102070
    | Code102071 = 102071
    | Code102072 = 102072
    | Code103001 = 103001
    | Code103002 = 103002
    | Code103003 = 103003
    | Code103004 = 103004
    | Code103005 = 103005
    | Code103006 = 103006
    | Code103007 = 103007
    | Code103008 = 103008

type mcnerror =
    { code: Code
      documentation_url: Option<string>
      message: string
      meta: Option<mcnerrormeta>
      source: Option<mcnerrorsource> }
    ///Creates an instance of mcnerror with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: Code, message: string): mcnerror =
        { code = code
          documentation_url = None
          message = message
          meta = None
          source = None }

type mcnerrormeta =
    { l10n_key: Option<string>
      loggable_error: Option<string>
      template_data: Option<Newtonsoft.Json.Linq.JObject>
      trace_id: Option<string> }
    ///Creates an instance of mcnerrormeta with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnerrormeta =
        { l10n_key = None
          loggable_error = None
          template_data = None
          trace_id = None }

type mcnerrorsource =
    { parameter: Option<string>
      parameter_value_index: Option<int>
      pointer: Option<string> }
    ///Creates an instance of mcnerrorsource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnerrorsource =
        { parameter = None
          parameter_value_index = None
          pointer = None }

type mcngcpsetup =
    { integration_identity_tag: string
      item_type: string
      tag_cli_command: string }
    ///Creates an instance of mcngcpsetup with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (integration_identity_tag: string, item_type: string, tag_cli_command: string): mcngcpsetup =
        { integration_identity_tag = integration_identity_tag
          item_type = item_type
          tag_cli_command = tag_cli_command }

type mcngetmagicwanaddressspaceresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnmagicwanaddressspace> }
    ///Creates an instance of mcngetmagicwanaddressspaceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcngetmagicwanaddressspaceresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcngetonrampresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnonramp> }
    ///Creates an instance of mcngetonrampresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcngetonrampresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcngoodresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>> }
    ///Creates an instance of mcngoodresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcngoodresponse =
        { messages = None
          success = None
          errors = None }

type mcngoodresponsecollection =
    { messages: Option<list<mcnerror>>
      result_info: Option<mcnresultinfo>
      success: Option<bool>
      errors: Option<list<mcnerror>> }
    ///Creates an instance of mcngoodresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcngoodresponsecollection =
        { messages = None
          result_info = None
          success = None
          errors = None }

type mcnlistitem =
    { item_type: string
      list: Newtonsoft.Json.Linq.JArray }
    ///Creates an instance of mcnlistitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (item_type: string, list: Newtonsoft.Json.Linq.JArray): mcnlistitem =
        { item_type = item_type; list = list }

type mcnlistonrampsresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<list<mcnonramp>> }
    ///Creates an instance of mcnlistonrampsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnlistonrampsresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnmagicwanaddressspace =
    { prefixes: list<mcncidrprefix> }
    ///Creates an instance of mcnmagicwanaddressspace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prefixes: list<mcncidrprefix>): mcnmagicwanaddressspace = { prefixes = prefixes }

type mcnobservation =
    { first_observed_at: string
      last_observed_at: string
      provider_id: mcnproviderid
      resource_id: mcnresourceid }
    ///Creates an instance of mcnobservation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (first_observed_at: string,
                          last_observed_at: string,
                          provider_id: mcnproviderid,
                          resource_id: mcnresourceid): mcnobservation =
        { first_observed_at = first_observed_at
          last_observed_at = last_observed_at
          provider_id = provider_id
          resource_id = resource_id }

type mcnonramp =
    { attached_hubs: Option<list<mcnresourceid>>
      attached_vpcs: Option<list<mcnresourceid>>
      cloud_asn: Option<int>
      cloud_type: mcnonrampcloudtype
      description: Option<string>
      dynamic_routing: bool
      hub: Option<mcnresourceid>
      id: mcnonrampid
      install_routes_in_cloud: bool
      install_routes_in_magic_wan: bool
      last_applied_at: Option<string>
      last_exported_at: Option<string>
      last_planned_at: Option<string>
      manage_hub_to_hub_attachments: Option<bool>
      manage_vpc_to_hub_attachments: Option<bool>
      name: string
      planned_monthly_cost_estimate: Option<mcncostdiff>
      planned_resources: Option<list<mcnresourcediff>>
      planned_resources_unavailable: Option<bool>
      post_apply_monthly_cost_estimate: Option<mcncost>
      post_apply_resources: Option<Map<string, mcnresourcedetails>>
      post_apply_resources_unavailable: Option<bool>
      region: Option<string>
      status: Option<mcnonrampstatus>
      ``type``: mcnonramptype
      updated_at: string
      vpc: Option<mcnresourceid>
      vpcs_by_id: Option<Map<string, mcnresourcedetails>>
      ///The list of vpc IDs for which resource details failed to generate.
      vpcs_by_id_unavailable: Option<list<mcnresourceid>> }
    ///Creates an instance of mcnonramp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloud_type: mcnonrampcloudtype,
                          dynamic_routing: bool,
                          id: mcnonrampid,
                          install_routes_in_cloud: bool,
                          install_routes_in_magic_wan: bool,
                          name: string,
                          ``type``: mcnonramptype,
                          updated_at: string): mcnonramp =
        { attached_hubs = None
          attached_vpcs = None
          cloud_asn = None
          cloud_type = cloud_type
          description = None
          dynamic_routing = dynamic_routing
          hub = None
          id = id
          install_routes_in_cloud = install_routes_in_cloud
          install_routes_in_magic_wan = install_routes_in_magic_wan
          last_applied_at = None
          last_exported_at = None
          last_planned_at = None
          manage_hub_to_hub_attachments = None
          manage_vpc_to_hub_attachments = None
          name = name
          planned_monthly_cost_estimate = None
          planned_resources = None
          planned_resources_unavailable = None
          post_apply_monthly_cost_estimate = None
          post_apply_resources = None
          post_apply_resources_unavailable = None
          region = None
          status = None
          ``type`` = ``type``
          updated_at = updated_at
          vpc = None
          vpcs_by_id = None
          vpcs_by_id_unavailable = None }

type mcnonrampstatus =
    { apply_progress: mcnapplyprogress
      lifecycle_errors: Option<Map<string, mcnerror>>
      lifecycle_state: mcnonramplifecyclestate
      plan_progress: mcnplanprogress
      routes: list<mcnconduitrouteid>
      tunnels: list<mcnconduittunnelid> }
    ///Creates an instance of mcnonrampstatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (apply_progress: mcnapplyprogress,
                          lifecycle_state: mcnonramplifecyclestate,
                          plan_progress: mcnplanprogress,
                          routes: list<mcnconduitrouteid>,
                          tunnels: list<mcnconduittunnelid>): mcnonrampstatus =
        { apply_progress = apply_progress
          lifecycle_errors = None
          lifecycle_state = lifecycle_state
          plan_progress = plan_progress
          routes = routes
          tunnels = tunnels }

type mcnplanprogress =
    { ``done``: int
      total: int }
    ///Creates an instance of mcnplanprogress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``done``: int, total: int): mcnplanprogress = { ``done`` = ``done``; total = total }

type mcnprovider =
    { aws_arn: Option<string>
      azure_subscription_id: Option<string>
      azure_tenant_id: Option<string>
      cloud_type: mcncloudtype
      description: Option<string>
      friendly_name: string
      gcp_project_id: Option<string>
      gcp_service_account_email: Option<string>
      id: mcnproviderid
      last_updated: string
      lifecycle_state: mcnproviderlifecyclestate
      state: mcnproviderdiscoverystatus
      state_v2: mcnproviderdiscoverystatus
      status: Option<mcnproviderstatus> }
    ///Creates an instance of mcnprovider with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloud_type: mcncloudtype,
                          friendly_name: string,
                          id: mcnproviderid,
                          last_updated: string,
                          lifecycle_state: mcnproviderlifecyclestate,
                          state: mcnproviderdiscoverystatus,
                          state_v2: mcnproviderdiscoverystatus): mcnprovider =
        { aws_arn = None
          azure_subscription_id = None
          azure_tenant_id = None
          cloud_type = cloud_type
          description = None
          friendly_name = friendly_name
          gcp_project_id = None
          gcp_service_account_email = None
          id = id
          last_updated = last_updated
          lifecycle_state = lifecycle_state
          state = state
          state_v2 = state_v2
          status = None }

type mcnproviderdiscoveryprogress =
    { ``done``: int
      total: int
      unit: string }
    ///Creates an instance of mcnproviderdiscoveryprogress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``done``: int, total: int, unit: string): mcnproviderdiscoveryprogress =
        { ``done`` = ``done``
          total = total
          unit = unit }

type mcnproviderinitialsetupresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of mcnproviderinitialsetupresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnproviderinitialsetupresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnproviderstatus =
    { credentials_good_since: Option<string>
      credentials_missing_since: Option<string>
      credentials_rejected_since: Option<string>
      discovery_message: Option<string>
      discovery_message_v2: Option<string>
      discovery_progress: mcnproviderdiscoveryprogress
      discovery_progress_v2: mcnproviderdiscoveryprogress
      in_use_by: Option<list<mcncloudplatformclient>>
      last_discovery_completed_at: Option<string>
      last_discovery_completed_at_v2: Option<string>
      last_discovery_started_at: Option<string>
      last_discovery_started_at_v2: Option<string>
      last_discovery_status: mcnproviderdiscoverystatus
      last_discovery_status_v2: mcnproviderdiscoverystatus
      last_updated: Option<string>
      regions: list<string> }
    ///Creates an instance of mcnproviderstatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (discovery_progress: mcnproviderdiscoveryprogress,
                          discovery_progress_v2: mcnproviderdiscoveryprogress,
                          last_discovery_status: mcnproviderdiscoverystatus,
                          last_discovery_status_v2: mcnproviderdiscoverystatus,
                          regions: list<string>): mcnproviderstatus =
        { credentials_good_since = None
          credentials_missing_since = None
          credentials_rejected_since = None
          discovery_message = None
          discovery_message_v2 = None
          discovery_progress = discovery_progress
          discovery_progress_v2 = discovery_progress_v2
          in_use_by = None
          last_discovery_completed_at = None
          last_discovery_completed_at_v2 = None
          last_discovery_started_at = None
          last_discovery_started_at_v2 = None
          last_discovery_status = last_discovery_status
          last_discovery_status_v2 = last_discovery_status_v2
          last_updated = None
          regions = regions }

type mcnreadaccountcatalogsyncresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcncatalogsync> }
    ///Creates an instance of mcnreadaccountcatalogsyncresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountcatalogsyncresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnreadaccountcatalogsyncsresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<list<mcncatalogsync>> }
    ///Creates an instance of mcnreadaccountcatalogsyncsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountcatalogsyncsresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnreadaccountproviderresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnprovider> }
    ///Creates an instance of mcnreadaccountproviderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountproviderresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnreadaccountprovidersresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<list<mcnprovider>> }
    ///Creates an instance of mcnreadaccountprovidersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountprovidersresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnreadaccountresourceresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnresourcedetails> }
    ///Creates an instance of mcnreadaccountresourceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountresourceresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnreadaccountresourcesresponse =
    { messages: Option<list<mcnerror>>
      result_info: Option<mcnresultinfo>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<list<mcnresourcedetails>> }
    ///Creates an instance of mcnreadaccountresourcesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnreadaccountresourcesresponse =
        { messages = None
          result_info = None
          success = None
          errors = None
          result = None }

type mcnrefreshcatalogsyncresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnpolicyresult> }
    ///Creates an instance of mcnrefreshcatalogsyncresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnrefreshcatalogsyncresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnresourcedetails =
    { account_id: mcnaccountid
      cloud_type: mcncloudtype
      config: Newtonsoft.Json.Linq.JObject
      deployment_provider: mcnproviderid
      id: mcnresourceid
      managed: bool
      managed_by: Option<list<mcncloudplatformclient>>
      monthly_cost_estimate: mcncost
      name: string
      native_id: string
      observations: Map<string, mcnobservation>
      provider_ids: list<mcnproviderid>
      provider_names_by_id: Map<string, string>
      region: string
      resource_group: string
      resource_type: mcnresourcetype
      sections: list<mcnresourcedetailssection>
      state: Newtonsoft.Json.Linq.JObject
      tags: Map<string, string>
      updated_at: string
      url: string }
    ///Creates an instance of mcnresourcedetails with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: mcnaccountid,
                          cloud_type: mcncloudtype,
                          config: Newtonsoft.Json.Linq.JObject,
                          deployment_provider: mcnproviderid,
                          id: mcnresourceid,
                          managed: bool,
                          monthly_cost_estimate: mcncost,
                          name: string,
                          native_id: string,
                          observations: Map<string, mcnobservation>,
                          provider_ids: list<mcnproviderid>,
                          provider_names_by_id: Map<string, string>,
                          region: string,
                          resource_group: string,
                          resource_type: mcnresourcetype,
                          sections: list<mcnresourcedetailssection>,
                          state: Newtonsoft.Json.Linq.JObject,
                          tags: Map<string, string>,
                          updated_at: string,
                          url: string): mcnresourcedetails =
        { account_id = account_id
          cloud_type = cloud_type
          config = config
          deployment_provider = deployment_provider
          id = id
          managed = managed
          managed_by = None
          monthly_cost_estimate = monthly_cost_estimate
          name = name
          native_id = native_id
          observations = observations
          provider_ids = provider_ids
          provider_names_by_id = provider_names_by_id
          region = region
          resource_group = resource_group
          resource_type = resource_type
          sections = sections
          state = state
          tags = tags
          updated_at = updated_at
          url = url }

type mcnresourcedetailssection =
    { help_text: Option<string>
      hidden_items: list<mcnresourcedetailssectionitem>
      name: string
      visible_items: list<mcnresourcedetailssectionitem> }
    ///Creates an instance of mcnresourcedetailssection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (hidden_items: list<mcnresourcedetailssectionitem>,
                          name: string,
                          visible_items: list<mcnresourcedetailssectionitem>): mcnresourcedetailssection =
        { help_text = None
          hidden_items = hidden_items
          name = name
          visible_items = visible_items }

type mcnresourcedetailssectionitem =
    { helpText: Option<string>
      name: Option<string>
      value: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of mcnresourcedetailssectionitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnresourcedetailssectionitem =
        { helpText = None
          name = None
          value = None }

type mcnresourcediff =
    { diff: mcnyamldiff
      keys_require_replace: list<string>
      monthly_cost_estimate_diff: mcncostdiff
      planned_action: mcnplannedaction
      resource: mcnresourcepreview }
    ///Creates an instance of mcnresourcediff with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (diff: mcnyamldiff,
                          keys_require_replace: list<string>,
                          monthly_cost_estimate_diff: mcncostdiff,
                          planned_action: mcnplannedaction,
                          resource: mcnresourcepreview): mcnresourcediff =
        { diff = diff
          keys_require_replace = keys_require_replace
          monthly_cost_estimate_diff = monthly_cost_estimate_diff
          planned_action = planned_action
          resource = resource }

type mcnresourcepreview =
    { cloud_type: mcncloudtype
      detail: string
      id: mcnresourceid
      name: string
      resource_type: mcnresourcetype
      title: string }
    ///Creates an instance of mcnresourcepreview with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cloud_type: mcncloudtype,
                          detail: string,
                          id: mcnresourceid,
                          name: string,
                          resource_type: mcnresourcetype,
                          title: string): mcnresourcepreview =
        { cloud_type = cloud_type
          detail = detail
          id = id
          name = name
          resource_type = resource_type
          title = title }

type mcnresourcepreviewitem =
    { item_type: string
      resource_preview: mcnresourcepreview }
    ///Creates an instance of mcnresourcepreviewitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (item_type: string, resource_preview: mcnresourcepreview): mcnresourcepreviewitem =
        { item_type = item_type
          resource_preview = resource_preview }

type mcnresourcescatalogpolicypreviewrequest =
    { policy: string }
    ///Creates an instance of mcnresourcescatalogpolicypreviewrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (policy: string): mcnresourcescatalogpolicypreviewrequest = { policy = policy }

type mcnresourcescatalogpolicypreviewresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnresourcescatalogpolicypreview> }
    ///Creates an instance of mcnresourcescatalogpolicypreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnresourcescatalogpolicypreviewresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnresponse =
    { messages: list<mcnerror>
      success: bool }
    ///Creates an instance of mcnresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<mcnerror>, success: bool): mcnresponse =
        { messages = messages
          success = success }

type mcnresponsecollection =
    { messages: list<mcnerror>
      result_info: Option<mcnresultinfo>
      success: bool }
    ///Creates an instance of mcnresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<mcnerror>, success: bool): mcnresponsecollection =
        { messages = messages
          result_info = None
          success = success }

type mcnresultinfo =
    { ///The number of items in the current result set.
      count: int
      ///The current page (starts from zero).
      page: int
      ///The maximum number of items per page.
      per_page: int
      ///The total number of items in the entire result set.
      total_count: int
      ///The number of total pages in the entire result set.
      total_pages: Option<int> }
    ///Creates an instance of mcnresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, page: int, per_page: int, total_count: int): mcnresultinfo =
        { count = count
          page = page
          per_page = per_page
          total_count = total_count
          total_pages = None }

type mcnstringitem =
    { item_type: string
      string: string }
    ///Creates an instance of mcnstringitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (item_type: string, string: string): mcnstringitem =
        { item_type = item_type
          string = string }

type mcnupdatecatalogsyncrequest =
    { description: Option<string>
      name: Option<string>
      policy: Option<string>
      update_mode: Option<mcncatalogsyncupdatemode> }
    ///Creates an instance of mcnupdatecatalogsyncrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdatecatalogsyncrequest =
        { description = None
          name = None
          policy = None
          update_mode = None }

type mcnupdatecatalogsyncresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcncatalogsync> }
    ///Creates an instance of mcnupdatecatalogsyncresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdatecatalogsyncresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnupdatemagicwanaddressspacerequest =
    { prefixes: list<mcncidrprefix> }
    ///Creates an instance of mcnupdatemagicwanaddressspacerequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prefixes: list<mcncidrprefix>): mcnupdatemagicwanaddressspacerequest = { prefixes = prefixes }

type mcnupdatemagicwanaddressspaceresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnmagicwanaddressspace> }
    ///Creates an instance of mcnupdatemagicwanaddressspaceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdatemagicwanaddressspaceresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnupdateonramprequest =
    { attached_hubs: Option<list<mcnresourceid>>
      attached_vpcs: Option<list<mcnresourceid>>
      description: Option<string>
      install_routes_in_cloud: Option<bool>
      install_routes_in_magic_wan: Option<bool>
      manage_hub_to_hub_attachments: Option<bool>
      manage_vpc_to_hub_attachments: Option<bool>
      name: Option<string>
      vpc: Option<mcnresourceid> }
    ///Creates an instance of mcnupdateonramprequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdateonramprequest =
        { attached_hubs = None
          attached_vpcs = None
          description = None
          install_routes_in_cloud = None
          install_routes_in_magic_wan = None
          manage_hub_to_hub_attachments = None
          manage_vpc_to_hub_attachments = None
          name = None
          vpc = None }

type mcnupdateonrampresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnonramp> }
    ///Creates an instance of mcnupdateonrampresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdateonrampresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnupdateproviderrequest =
    { aws_arn: Option<string>
      azure_subscription_id: Option<string>
      azure_tenant_id: Option<string>
      description: Option<string>
      friendly_name: Option<string>
      gcp_project_id: Option<string>
      gcp_service_account_email: Option<string> }
    ///Creates an instance of mcnupdateproviderrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdateproviderrequest =
        { aws_arn = None
          azure_subscription_id = None
          azure_tenant_id = None
          description = None
          friendly_name = None
          gcp_project_id = None
          gcp_service_account_email = None }

type mcnupdateproviderresponse =
    { messages: Option<list<mcnerror>>
      success: Option<bool>
      errors: Option<list<mcnerror>>
      result: Option<mcnprovider> }
    ///Creates an instance of mcnupdateproviderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mcnupdateproviderresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mcnyamldiff =
    { diff: string
      left_description: string
      left_yaml: string
      right_description: string
      right_yaml: string }
    ///Creates an instance of mcnyamldiff with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (diff: string,
                          left_description: string,
                          left_yaml: string,
                          right_description: string,
                          right_yaml: string): mcnyamldiff =
        { diff = diff
          left_description = left_description
          left_yaml = left_yaml
          right_description = right_description
          right_yaml = right_yaml }

type mcnyamldiffitem =
    { item_type: string
      yaml_diff: mcnyamldiff }
    ///Creates an instance of mcnyamldiffitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (item_type: string, yaml_diff: mcnyamldiff): mcnyamldiffitem =
        { item_type = item_type
          yaml_diff = yaml_diff }

type mcnyamlitem =
    { item_type: string
      yaml: string }
    ///Creates an instance of mcnyamlitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (item_type: string, yaml: string): mcnyamlitem = { item_type = item_type; yaml = yaml }

type mconnbadresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of mconnbadresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconnbadresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncodedmessage =
    { code: float
      message: string }
    ///Creates an instance of mconncodedmessage with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: float, message: string): mconncodedmessage = { code = code; message = message }

type mconncustomerconnector =
    { activated: bool
      device: Option<mconncustomerdevice>
      id: mconnuuid
      ///Allowed days of the week for upgrades. Default is all days.
      interrupt_window_days_of_week: list<mconndayofweek>
      interrupt_window_duration_hours: float
      ///List of dates (YYYY-MM-DD) when upgrades are blocked.
      interrupt_window_embargo_dates: list<mconnembargodate>
      interrupt_window_hour_of_day: float
      last_heartbeat: Option<string>
      last_seen_version: Option<string>
      last_updated: string
      license_key: Option<string>
      notes: string
      timezone: string }
    ///Creates an instance of mconncustomerconnector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (activated: bool,
                          id: mconnuuid,
                          interrupt_window_days_of_week: list<mconndayofweek>,
                          interrupt_window_duration_hours: float,
                          interrupt_window_embargo_dates: list<mconnembargodate>,
                          interrupt_window_hour_of_day: float,
                          last_updated: string,
                          notes: string,
                          timezone: string): mconncustomerconnector =
        { activated = activated
          device = None
          id = id
          interrupt_window_days_of_week = interrupt_window_days_of_week
          interrupt_window_duration_hours = interrupt_window_duration_hours
          interrupt_window_embargo_dates = interrupt_window_embargo_dates
          interrupt_window_hour_of_day = interrupt_window_hour_of_day
          last_heartbeat = None
          last_seen_version = None
          last_updated = last_updated
          license_key = None
          notes = notes
          timezone = timezone }

type mconncustomerconnectorcreaterequest =
    { ///Exactly one of id, serial_number, or provision_license must be provided.
      device: Option<mconncustomerdeviceoptions>
      activated: Option<bool>
      ///Allowed days of the week for upgrades. Default is all days.
      interrupt_window_days_of_week: Option<list<mconndayofweek>>
      interrupt_window_duration_hours: Option<float>
      ///List of dates (YYYY-MM-DD) when upgrades are blocked.
      interrupt_window_embargo_dates: Option<list<mconnembargodate>>
      interrupt_window_hour_of_day: Option<float>
      notes: Option<string>
      timezone: Option<string> }
    ///Creates an instance of mconncustomerconnectorcreaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorcreaterequest =
        { device = None
          activated = None
          interrupt_window_days_of_week = None
          interrupt_window_duration_hours = None
          interrupt_window_embargo_dates = None
          interrupt_window_hour_of_day = None
          notes = None
          timezone = None }

type mconncustomerconnectorcreateresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<mconncustomerconnector> }
    ///Creates an instance of mconncustomerconnectorcreateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorcreateresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncustomerconnectordeleteresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<mconncustomerconnector> }
    ///Creates an instance of mconncustomerconnectordeleteresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectordeleteresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncustomerconnectorfetchresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<mconncustomerconnector> }
    ///Creates an instance of mconncustomerconnectorfetchresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorfetchresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncustomerconnectorfields =
    { activated: Option<bool>
      ///Allowed days of the week for upgrades. Default is all days.
      interrupt_window_days_of_week: Option<list<mconndayofweek>>
      interrupt_window_duration_hours: Option<float>
      ///List of dates (YYYY-MM-DD) when upgrades are blocked.
      interrupt_window_embargo_dates: Option<list<mconnembargodate>>
      interrupt_window_hour_of_day: Option<float>
      notes: Option<string>
      timezone: Option<string> }
    ///Creates an instance of mconncustomerconnectorfields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorfields =
        { activated = None
          interrupt_window_days_of_week = None
          interrupt_window_duration_hours = None
          interrupt_window_embargo_dates = None
          interrupt_window_hour_of_day = None
          notes = None
          timezone = None }

type mconncustomerconnectorlistresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<list<mconncustomerconnector>> }
    ///Creates an instance of mconncustomerconnectorlistresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorlistresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncustomerconnectorupdaterequest =
    { activated: Option<bool>
      ///Allowed days of the week for upgrades. Default is all days.
      interrupt_window_days_of_week: Option<list<mconndayofweek>>
      interrupt_window_duration_hours: Option<float>
      ///List of dates (YYYY-MM-DD) when upgrades are blocked.
      interrupt_window_embargo_dates: Option<list<mconnembargodate>>
      interrupt_window_hour_of_day: Option<float>
      notes: Option<string>
      timezone: Option<string>
      ///When true, regenerate license key for the connector.
      provision_license: Option<bool> }
    ///Creates an instance of mconncustomerconnectorupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorupdaterequest =
        { activated = None
          interrupt_window_days_of_week = None
          interrupt_window_duration_hours = None
          interrupt_window_embargo_dates = None
          interrupt_window_hour_of_day = None
          notes = None
          timezone = None
          provision_license = None }

type mconncustomerconnectorupdateresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>>
      result: Option<mconncustomerconnector> }
    ///Creates an instance of mconncustomerconnectorupdateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerconnectorupdateresponse =
        { messages = None
          success = None
          errors = None
          result = None }

type mconncustomerdevice =
    { id: mconnuuid
      serial_number: Option<string> }
    ///Creates an instance of mconncustomerdevice with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: mconnuuid): mconncustomerdevice = { id = id; serial_number = None }

///Exactly one of id, serial_number, or provision_license must be provided.
type mconncustomerdeviceoptions =
    { id: Option<string>
      ///When true, create and provision a new licence key for the connector.
      provision_license: Option<bool>
      serial_number: Option<string> }
    ///Creates an instance of mconncustomerdeviceoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomerdeviceoptions =
        { id = None
          provision_license = None
          serial_number = None }

type mconncustomereventgetsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      ///Recorded Event
      result: Option<mconnrecordedevent> }
    ///Creates an instance of mconncustomereventgetsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomereventgetsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconncustomereventsgetlatestresult =
    { count: float
      items: list<mconnrecordedevent> }
    ///Creates an instance of mconncustomereventsgetlatestresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, items: list<mconnrecordedevent>): mconncustomereventsgetlatestresult =
        { count = count; items = items }

type mconncustomereventsgetlatestsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      result: Option<mconncustomereventsgetlatestresult> }
    ///Creates an instance of mconncustomereventsgetlatestsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomereventsgetlatestsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconncustomereventsgetresult =
    { count: float
      cursor: Option<string>
      items: list<mconneventmetadata> }
    ///Creates an instance of mconncustomereventsgetresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, items: list<mconneventmetadata>): mconncustomereventsgetresult =
        { count = count
          cursor = None
          items = items }

type mconncustomereventsgetsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      result: Option<mconncustomereventsgetresult> }
    ///Creates an instance of mconncustomereventsgetsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomereventsgetsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconncustomersnapshotgetsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      ///Snapshot
      result: Option<mconnsnapshot> }
    ///Creates an instance of mconncustomersnapshotgetsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomersnapshotgetsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconncustomersnapshotsgetlatestresult =
    { count: float
      items: list<mconnsnapshot> }
    ///Creates an instance of mconncustomersnapshotsgetlatestresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, items: list<mconnsnapshot>): mconncustomersnapshotsgetlatestresult =
        { count = count; items = items }

type mconncustomersnapshotsgetlatestsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      result: Option<mconncustomersnapshotsgetlatestresult> }
    ///Creates an instance of mconncustomersnapshotsgetlatestsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomersnapshotsgetlatestsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconncustomersnapshotsgetresult =
    { count: float
      cursor: Option<string>
      items: list<mconnsnapshotmetadata> }
    ///Creates an instance of mconncustomersnapshotsgetresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: float, items: list<mconnsnapshotmetadata>): mconncustomersnapshotsgetresult =
        { count = count
          cursor = None
          items = items }

type mconncustomersnapshotsgetsuccess =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      result: Option<mconncustomersnapshotsgetresult> }
    ///Creates an instance of mconncustomersnapshotsgetsuccess with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconncustomersnapshotsgetsuccess =
        { errors = None
          messages = None
          success = None
          result = None }

type mconnenvelope =
    { errors: Option<list<mconncodedmessage>>
      messages: Option<list<mconncodedmessage>>
      success: bool }
    ///Creates an instance of mconnenvelope with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (success: bool): mconnenvelope =
        { errors = None
          messages = None
          success = success }

type mconneventmetadata =
    { ///Time the Event was collected (seconds since the Unix epoch)
      a: float
      ///Kind
      k: string
      ///Sequence number, used to order events with the same timestamp
      n: float
      ///Time the Event was recorded (seconds since the Unix epoch)
      t: float }
    ///Creates an instance of mconneventmetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (a: float, k: string, n: float, t: float): mconneventmetadata = { a = a; k = k; n = n; t = t }

type mconngoodresponse =
    { messages: Option<list<mconncodedmessage>>
      success: Option<bool>
      errors: Option<list<mconncodedmessage>> }
    ///Creates an instance of mconngoodresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): mconngoodresponse =
        { messages = None
          success = None
          errors = None }

///Recorded Event
type mconnrecordedevent =
    { e: Newtonsoft.Json.Linq.JObject
      ///Sequence number, used to order events with the same timestamp
      n: float
      ///Time the Event was recorded (seconds since the Unix epoch)
      t: float }
    ///Creates an instance of mconnrecordedevent with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (e: Newtonsoft.Json.Linq.JObject, n: float, t: float): mconnrecordedevent =
        { e = e; n = n; t = t }

type mconnresponse =
    { messages: list<mconncodedmessage>
      success: bool }
    ///Creates an instance of mconnresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<mconncodedmessage>, success: bool): mconnresponse =
        { messages = messages
          success = success }

///Snapshot
type mconnsnapshot =
    { bonds: Option<list<mconnsnapshotbond>>
      ///Count of failures to reclaim space
      count_reclaim_failures: float
      ///Count of reclaimed paths
      count_reclaimed_paths: float
      ///Count of failed snapshot recordings
      count_record_failed: float
      ///Count of failed snapshot transmissions
      count_transmit_failures: float
      ///Count of processors/cores
      cpu_count: Option<float>
      ///Percentage of time over a 10 second window that tasks were stalled
      cpu_pressure_10s: Option<float>
      ///Percentage of time over a 5 minute window that tasks were stalled
      cpu_pressure_300s: Option<float>
      ///Percentage of time over a 1 minute window that tasks were stalled
      cpu_pressure_60s: Option<float>
      ///Total stall time (microseconds)
      cpu_pressure_total_us: Option<float>
      ///Time spent running a virtual CPU or guest OS (milliseconds)
      cpu_time_guest_ms: Option<float>
      ///Time spent running a niced guest (milliseconds)
      cpu_time_guest_nice_ms: Option<float>
      ///Time spent in idle state (milliseconds)
      cpu_time_idle_ms: Option<float>
      ///Time spent wait for I/O to complete (milliseconds)
      cpu_time_iowait_ms: Option<float>
      ///Time spent servicing interrupts (milliseconds)
      cpu_time_irq_ms: Option<float>
      ///Time spent in low-priority user mode (milliseconds)
      cpu_time_nice_ms: Option<float>
      ///Time spent servicing softirqs (milliseconds)
      cpu_time_softirq_ms: Option<float>
      ///Time stolen (milliseconds)
      cpu_time_steal_ms: Option<float>
      ///Time spent in system mode (milliseconds)
      cpu_time_system_ms: Option<float>
      ///Time spent in user mode (milliseconds)
      cpu_time_user_ms: Option<float>
      dhcp_leases: Option<list<mconnsnapshotdhcplease>>
      disks: Option<list<mconnsnapshotdisk>>
      ///Name of high availability state
      ha_state: Option<string>
      ///Numeric value associated with high availability state (0 = disabled, 1 = active, 2 = standby, 3 = stopped, 4 = fault)
      ha_value: Option<float>
      interfaces: Option<list<mconnsnapshotinterface>>
      ///Percentage of time over a 10 second window that all tasks were stalled
      io_pressure_full_10s: Option<float>
      ///Percentage of time over a 5 minute window that all tasks were stalled
      io_pressure_full_300s: Option<float>
      ///Percentage of time over a 1 minute window that all tasks were stalled
      io_pressure_full_60s: Option<float>
      ///Total stall time (microseconds)
      io_pressure_full_total_us: Option<float>
      ///Percentage of time over a 10 second window that some tasks were stalled
      io_pressure_some_10s: Option<float>
      ///Percentage of time over a 3 minute window that some tasks were stalled
      io_pressure_some_300s: Option<float>
      ///Percentage of time over a 1 minute window that some tasks were stalled
      io_pressure_some_60s: Option<float>
      ///Total stall time (microseconds)
      io_pressure_some_total_us: Option<float>
      ///Boot time (seconds since Unix epoch)
      kernel_btime: Option<float>
      ///Number of context switches that the system underwent
      kernel_ctxt: Option<float>
      ///Number of forks since boot
      kernel_processes: Option<float>
      ///Number of processes blocked waiting for I/O
      kernel_processes_blocked: Option<float>
      ///Number of processes in runnable state
      kernel_processes_running: Option<float>
      ///The fifteen-minute load average
      load_average_15m: Option<float>
      ///The one-minute load average
      load_average_1m: Option<float>
      ///The five-minute load average
      load_average_5m: Option<float>
      ///Number of currently runnable kernel scheduling entities
      load_average_cur: Option<float>
      ///Number of kernel scheduling entities that currently exist on the system
      load_average_max: Option<float>
      ///Memory that has been used more recently
      memory_active_bytes: Option<float>
      ///Non-file backed huge pages mapped into user-space page tables
      memory_anon_hugepages_bytes: Option<float>
      ///Non-file backed pages mapped into user-space page tables
      memory_anon_pages_bytes: Option<float>
      ///Estimate of how much memory is available for starting new applications
      memory_available_bytes: Option<float>
      ///Memory used for block device bounce buffers
      memory_bounce_bytes: Option<float>
      ///Relatively temporary storage for raw disk blocks
      memory_buffers_bytes: Option<float>
      ///In-memory cache for files read from the disk
      memory_cached_bytes: Option<float>
      ///Free CMA (Contiguous Memory Allocator) pages
      memory_cma_free_bytes: Option<float>
      ///Total CMA (Contiguous Memory Allocator) pages
      memory_cma_total_bytes: Option<float>
      ///Total amount of memory currently available to be allocated on the system
      memory_commit_limit_bytes: Option<float>
      ///Amount of memory presently allocated on the system
      memory_committed_as_bytes: Option<float>
      ///Memory which is waiting to get written back to the disk
      memory_dirty_bytes: Option<float>
      ///The sum of LowFree and HighFree
      memory_free_bytes: Option<float>
      ///Amount of free highmem
      memory_high_free_bytes: Option<float>
      ///Total amount of highmem
      memory_high_total_bytes: Option<float>
      ///The number of huge pages in the pool that are not yet allocated
      memory_hugepages_free: Option<float>
      ///Number of huge pages for which a commitment has been made, but no allocation has yet been made
      memory_hugepages_rsvd: Option<float>
      ///Number of huge pages in the pool above the threshold
      memory_hugepages_surp: Option<float>
      ///The size of the pool of huge pages
      memory_hugepages_total: Option<float>
      ///The size of huge pages
      memory_hugepagesize_bytes: Option<float>
      ///Memory which has been less recently used
      memory_inactive_bytes: Option<float>
      ///Kernel allocations that the kernel will attempt to reclaim under memory pressure
      memory_k_reclaimable_bytes: Option<float>
      ///Amount of memory allocated to kernel stacks
      memory_kernel_stack_bytes: Option<float>
      ///Amount of free lowmem
      memory_low_free_bytes: Option<float>
      ///Total amount of lowmem
      memory_low_total_bytes: Option<float>
      ///Files which have been mapped into memory
      memory_mapped_bytes: Option<float>
      ///Amount of memory dedicated to the lowest level of page tables
      memory_page_tables_bytes: Option<float>
      ///Memory allocated to the per-cpu alloctor used to back per-cpu allocations
      memory_per_cpu_bytes: Option<float>
      ///Percentage of time over a 10 second window that all tasks were stalled
      memory_pressure_full_10s: Option<float>
      ///Percentage of time over a 5 minute window that all tasks were stalled
      memory_pressure_full_300s: Option<float>
      ///Percentage of time over a 1 minute window that all tasks were stalled
      memory_pressure_full_60s: Option<float>
      ///Total stall time (microseconds)
      memory_pressure_full_total_us: Option<float>
      ///Percentage of time over a 10 second window that some tasks were stalled
      memory_pressure_some_10s: Option<float>
      ///Percentage of time over a 5 minute window that some tasks were stalled
      memory_pressure_some_300s: Option<float>
      ///Percentage of time over a 1 minute window that some tasks were stalled
      memory_pressure_some_60s: Option<float>
      ///Total stall time (microseconds)
      memory_pressure_some_total_us: Option<float>
      ///Part of slab that can be reclaimed on memory pressure
      memory_s_reclaimable_bytes: Option<float>
      ///Part of slab that cannot be reclaimed on memory pressure
      memory_s_unreclaim_bytes: Option<float>
      ///Amount of memory dedicated to the lowest level of page tables
      memory_secondary_page_tables_bytes: Option<float>
      ///Amount of memory consumed by tmpfs
      memory_shmem_bytes: Option<float>
      ///Memory used by shmem and tmpfs, allocated with huge pages
      memory_shmem_hugepages_bytes: Option<float>
      ///Shared memory mapped into user space with huge pages
      memory_shmem_pmd_mapped_bytes: Option<float>
      ///In-kernel data structures cache
      memory_slab_bytes: Option<float>
      ///Memory swapped out and back in while still in swap file
      memory_swap_cached_bytes: Option<float>
      ///Amount of swap space that is currently unused
      memory_swap_free_bytes: Option<float>
      ///Total amount of swap space available
      memory_swap_total_bytes: Option<float>
      ///Total usable RAM
      memory_total_bytes: Option<float>
      ///Largest contiguous block of vmalloc area which is free
      memory_vmalloc_chunk_bytes: Option<float>
      ///Total size of vmalloc memory area
      memory_vmalloc_total_bytes: Option<float>
      ///Amount of vmalloc area which is used
      memory_vmalloc_used_bytes: Option<float>
      ///Memory which is actively being written back to the disk
      memory_writeback_bytes: Option<float>
      ///Memory used by FUSE for temporary writeback buffers
      memory_writeback_tmp_bytes: Option<float>
      ///Memory consumed by the zswap backend, compressed
      memory_z_swap_bytes: Option<float>
      ///Amount of anonymous memory stored in zswap, uncompressed
      memory_z_swapped_bytes: Option<float>
      mounts: Option<list<mconnsnapshotmount>>
      netdevs: Option<list<mconnsnapshotnetdev>>
      ///Number of ICMP Address Mask Reply messages received
      snmp_icmp_in_addr_mask_reps: Option<float>
      ///Number of ICMP Address Mask Request messages received
      snmp_icmp_in_addr_masks: Option<float>
      ///Number of ICMP messages received with bad checksums
      snmp_icmp_in_csum_errors: Option<float>
      ///Number of ICMP Destination Unreachable messages received
      snmp_icmp_in_dest_unreachs: Option<float>
      ///Number of ICMP Echo Reply messages received
      snmp_icmp_in_echo_reps: Option<float>
      ///Number of ICMP Echo (request) messages received
      snmp_icmp_in_echos: Option<float>
      ///Number of ICMP messages received with ICMP-specific errors
      snmp_icmp_in_errors: Option<float>
      ///Number of ICMP messages received
      snmp_icmp_in_msgs: Option<float>
      ///Number of ICMP Parameter Problem messages received
      snmp_icmp_in_parm_probs: Option<float>
      ///Number of ICMP Redirect messages received
      snmp_icmp_in_redirects: Option<float>
      ///Number of ICMP Source Quench messages received
      snmp_icmp_in_src_quenchs: Option<float>
      ///Number of ICMP Time Exceeded messages received
      snmp_icmp_in_time_excds: Option<float>
      ///Number of ICMP Address Mask Request messages received
      snmp_icmp_in_timestamp_reps: Option<float>
      ///Number of ICMP Timestamp (request) messages received
      snmp_icmp_in_timestamps: Option<float>
      ///Number of ICMP Address Mask Reply messages sent
      snmp_icmp_out_addr_mask_reps: Option<float>
      ///Number of ICMP Address Mask Request messages sent
      snmp_icmp_out_addr_masks: Option<float>
      ///Number of ICMP Destination Unreachable messages sent
      snmp_icmp_out_dest_unreachs: Option<float>
      ///Number of ICMP Echo Reply messages sent
      snmp_icmp_out_echo_reps: Option<float>
      ///Number of ICMP Echo (request) messages sent
      snmp_icmp_out_echos: Option<float>
      ///Number of ICMP messages which this entity did not send due to ICMP-specific errors
      snmp_icmp_out_errors: Option<float>
      ///Number of ICMP messages attempted to send
      snmp_icmp_out_msgs: Option<float>
      ///Number of ICMP Parameter Problem messages sent
      snmp_icmp_out_parm_probs: Option<float>
      ///Number of ICMP Redirect messages sent
      snmp_icmp_out_redirects: Option<float>
      ///Number of ICMP Source Quench messages sent
      snmp_icmp_out_src_quenchs: Option<float>
      ///Number of ICMP Time Exceeded messages sent
      snmp_icmp_out_time_excds: Option<float>
      ///Number of ICMP Timestamp Reply messages sent
      snmp_icmp_out_timestamp_reps: Option<float>
      ///Number of ICMP Timestamp (request) messages sent
      snmp_icmp_out_timestamps: Option<float>
      ///Default value of the Time-To-Live field of the IP header
      snmp_ip_default_ttl: Option<float>
      ///Number of datagrams forwarded to their final destination
      snmp_ip_forw_datagrams: Option<float>
      ///Set when acting as an IP gateway
      snmp_ip_forwarding_enabled: Option<bool>
      ///Number of datagrams generated by fragmentation
      snmp_ip_frag_creates: Option<float>
      ///Number of datagrams discarded because fragmentation failed
      snmp_ip_frag_fails: Option<float>
      ///Number of datagrams successfully fragmented
      snmp_ip_frag_oks: Option<float>
      ///Number of input datagrams discarded due to errors in the IP address
      snmp_ip_in_addr_errors: Option<float>
      ///Number of input datagrams successfully delivered to IP user-protocols
      snmp_ip_in_delivers: Option<float>
      ///Number of input datagrams otherwise discarded
      snmp_ip_in_discards: Option<float>
      ///Number of input datagrams discarded due to errors in the IP header
      snmp_ip_in_hdr_errors: Option<float>
      ///Number of input datagrams received from interfaces
      snmp_ip_in_receives: Option<float>
      ///Number of input datagrams discarded due unknown or unsupported protocol
      snmp_ip_in_unknown_protos: Option<float>
      ///Number of output datagrams otherwise discarded
      snmp_ip_out_discards: Option<float>
      ///Number of output datagrams discarded because no route matched
      snmp_ip_out_no_routes: Option<float>
      ///Number of datagrams supplied for transmission
      snmp_ip_out_requests: Option<float>
      ///Number of failures detected by the reassembly algorithm
      snmp_ip_reasm_fails: Option<float>
      ///Number of datagrams successfully reassembled
      snmp_ip_reasm_oks: Option<float>
      ///Number of fragments received which needed to be reassembled
      snmp_ip_reasm_reqds: Option<float>
      ///Number of seconds fragments are held while awaiting reassembly
      snmp_ip_reasm_timeout: Option<float>
      ///Number of times TCP transitions to SYN-SENT from CLOSED
      snmp_tcp_active_opens: Option<float>
      ///Number of times TCP transitions to CLOSED from SYN-SENT or SYN-RCVD, plus transitions to LISTEN from SYN-RCVD
      snmp_tcp_attempt_fails: Option<float>
      ///Number of TCP connections in ESTABLISHED or CLOSE-WAIT
      snmp_tcp_curr_estab: Option<float>
      ///Number of times TCP transitions to CLOSED from ESTABLISHED or CLOSE-WAIT
      snmp_tcp_estab_resets: Option<float>
      ///Number of TCP segments received with checksum errors
      snmp_tcp_in_csum_errors: Option<float>
      ///Number of TCP segments received in error
      snmp_tcp_in_errs: Option<float>
      ///Number of TCP segments received
      snmp_tcp_in_segs: Option<float>
      ///Limit on the total number of TCP connections
      snmp_tcp_max_conn: Option<float>
      ///Number of TCP segments sent with RST flag
      snmp_tcp_out_rsts: Option<float>
      ///Number of TCP segments sent
      snmp_tcp_out_segs: Option<float>
      ///Number of times TCP transitions to SYN-RCVD from LISTEN
      snmp_tcp_passive_opens: Option<float>
      ///Number of TCP segments retransmitted
      snmp_tcp_retrans_segs: Option<float>
      ///Maximum value permitted by a TCP implementation for the retransmission timeout (milliseconds)
      snmp_tcp_rto_max: Option<float>
      ///Minimum value permitted by a TCP implementation for the retransmission timeout (milliseconds)
      snmp_tcp_rto_min: Option<float>
      ///Number of UDP datagrams delivered to UDP applications
      snmp_udp_in_datagrams: Option<float>
      ///Number of UDP datagrams failed to be delivered for reasons other than lack of application at the destination port
      snmp_udp_in_errors: Option<float>
      ///Number of UDP datagrams received for which there was not application at the destination port
      snmp_udp_no_ports: Option<float>
      ///Number of UDP datagrams sent
      snmp_udp_out_datagrams: Option<float>
      ///Boottime of the system (seconds since the Unix epoch)
      system_boot_time_s: Option<float>
      ///Time the Snapshot was recorded (seconds since the Unix epoch)
      t: float
      thermals: Option<list<mconnsnapshotthermal>>
      tunnels: Option<list<mconnsnapshottunnel>>
      ///Sum of how much time each core has spent idle
      uptime_idle_ms: Option<float>
      ///Uptime of the system, including time spent in suspend
      uptime_total_ms: Option<float>
      ///Version
      v: string }
    ///Creates an instance of mconnsnapshot with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count_reclaim_failures: float,
                          count_reclaimed_paths: float,
                          count_record_failed: float,
                          count_transmit_failures: float,
                          t: float,
                          v: string): mconnsnapshot =
        { bonds = None
          count_reclaim_failures = count_reclaim_failures
          count_reclaimed_paths = count_reclaimed_paths
          count_record_failed = count_record_failed
          count_transmit_failures = count_transmit_failures
          cpu_count = None
          cpu_pressure_10s = None
          cpu_pressure_300s = None
          cpu_pressure_60s = None
          cpu_pressure_total_us = None
          cpu_time_guest_ms = None
          cpu_time_guest_nice_ms = None
          cpu_time_idle_ms = None
          cpu_time_iowait_ms = None
          cpu_time_irq_ms = None
          cpu_time_nice_ms = None
          cpu_time_softirq_ms = None
          cpu_time_steal_ms = None
          cpu_time_system_ms = None
          cpu_time_user_ms = None
          dhcp_leases = None
          disks = None
          ha_state = None
          ha_value = None
          interfaces = None
          io_pressure_full_10s = None
          io_pressure_full_300s = None
          io_pressure_full_60s = None
          io_pressure_full_total_us = None
          io_pressure_some_10s = None
          io_pressure_some_300s = None
          io_pressure_some_60s = None
          io_pressure_some_total_us = None
          kernel_btime = None
          kernel_ctxt = None
          kernel_processes = None
          kernel_processes_blocked = None
          kernel_processes_running = None
          load_average_15m = None
          load_average_1m = None
          load_average_5m = None
          load_average_cur = None
          load_average_max = None
          memory_active_bytes = None
          memory_anon_hugepages_bytes = None
          memory_anon_pages_bytes = None
          memory_available_bytes = None
          memory_bounce_bytes = None
          memory_buffers_bytes = None
          memory_cached_bytes = None
          memory_cma_free_bytes = None
          memory_cma_total_bytes = None
          memory_commit_limit_bytes = None
          memory_committed_as_bytes = None
          memory_dirty_bytes = None
          memory_free_bytes = None
          memory_high_free_bytes = None
          memory_high_total_bytes = None
          memory_hugepages_free = None
          memory_hugepages_rsvd = None
          memory_hugepages_surp = None
          memory_hugepages_total = None
          memory_hugepagesize_bytes = None
          memory_inactive_bytes = None
          memory_k_reclaimable_bytes = None
          memory_kernel_stack_bytes = None
          memory_low_free_bytes = None
          memory_low_total_bytes = None
          memory_mapped_bytes = None
          memory_page_tables_bytes = None
          memory_per_cpu_bytes = None
          memory_pressure_full_10s = None
          memory_pressure_full_300s = None
          memory_pressure_full_60s = None
          memory_pressure_full_total_us = None
          memory_pressure_some_10s = None
          memory_pressure_some_300s = None
          memory_pressure_some_60s = None
          memory_pressure_some_total_us = None
          memory_s_reclaimable_bytes = None
          memory_s_unreclaim_bytes = None
          memory_secondary_page_tables_bytes = None
          memory_shmem_bytes = None
          memory_shmem_hugepages_bytes = None
          memory_shmem_pmd_mapped_bytes = None
          memory_slab_bytes = None
          memory_swap_cached_bytes = None
          memory_swap_free_bytes = None
          memory_swap_total_bytes = None
          memory_total_bytes = None
          memory_vmalloc_chunk_bytes = None
          memory_vmalloc_total_bytes = None
          memory_vmalloc_used_bytes = None
          memory_writeback_bytes = None
          memory_writeback_tmp_bytes = None
          memory_z_swap_bytes = None
          memory_z_swapped_bytes = None
          mounts = None
          netdevs = None
          snmp_icmp_in_addr_mask_reps = None
          snmp_icmp_in_addr_masks = None
          snmp_icmp_in_csum_errors = None
          snmp_icmp_in_dest_unreachs = None
          snmp_icmp_in_echo_reps = None
          snmp_icmp_in_echos = None
          snmp_icmp_in_errors = None
          snmp_icmp_in_msgs = None
          snmp_icmp_in_parm_probs = None
          snmp_icmp_in_redirects = None
          snmp_icmp_in_src_quenchs = None
          snmp_icmp_in_time_excds = None
          snmp_icmp_in_timestamp_reps = None
          snmp_icmp_in_timestamps = None
          snmp_icmp_out_addr_mask_reps = None
          snmp_icmp_out_addr_masks = None
          snmp_icmp_out_dest_unreachs = None
          snmp_icmp_out_echo_reps = None
          snmp_icmp_out_echos = None
          snmp_icmp_out_errors = None
          snmp_icmp_out_msgs = None
          snmp_icmp_out_parm_probs = None
          snmp_icmp_out_redirects = None
          snmp_icmp_out_src_quenchs = None
          snmp_icmp_out_time_excds = None
          snmp_icmp_out_timestamp_reps = None
          snmp_icmp_out_timestamps = None
          snmp_ip_default_ttl = None
          snmp_ip_forw_datagrams = None
          snmp_ip_forwarding_enabled = None
          snmp_ip_frag_creates = None
          snmp_ip_frag_fails = None
          snmp_ip_frag_oks = None
          snmp_ip_in_addr_errors = None
          snmp_ip_in_delivers = None
          snmp_ip_in_discards = None
          snmp_ip_in_hdr_errors = None
          snmp_ip_in_receives = None
          snmp_ip_in_unknown_protos = None
          snmp_ip_out_discards = None
          snmp_ip_out_no_routes = None
          snmp_ip_out_requests = None
          snmp_ip_reasm_fails = None
          snmp_ip_reasm_oks = None
          snmp_ip_reasm_reqds = None
          snmp_ip_reasm_timeout = None
          snmp_tcp_active_opens = None
          snmp_tcp_attempt_fails = None
          snmp_tcp_curr_estab = None
          snmp_tcp_estab_resets = None
          snmp_tcp_in_csum_errors = None
          snmp_tcp_in_errs = None
          snmp_tcp_in_segs = None
          snmp_tcp_max_conn = None
          snmp_tcp_out_rsts = None
          snmp_tcp_out_segs = None
          snmp_tcp_passive_opens = None
          snmp_tcp_retrans_segs = None
          snmp_tcp_rto_max = None
          snmp_tcp_rto_min = None
          snmp_udp_in_datagrams = None
          snmp_udp_in_errors = None
          snmp_udp_no_ports = None
          snmp_udp_out_datagrams = None
          system_boot_time_s = None
          t = t
          thermals = None
          tunnels = None
          uptime_idle_ms = None
          uptime_total_ms = None
          v = v }

///Snapshot Bond
type mconnsnapshotbond =
    { ///Name of the network interface
      name: string
      ///Current status of the network interface
      status: string }
    ///Creates an instance of mconnsnapshotbond with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, status: string): mconnsnapshotbond = { name = name; status = status }

///Snapshot DHCP lease
type mconnsnapshotdhcplease =
    { ///Client ID of the device the IP Address was leased to
      client_id: string
      ///Connector identifier
      connector_id: Option<string>
      ///Expiry time of the DHCP lease (seconds since the Unix epoch)
      expiry_time: float
      ///Hostname of the device the IP Address was leased to
      hostname: string
      ///Name of the network interface
      interface_name: string
      ///IP Address that was leased
      ip_address: string
      ///MAC Address of the device the IP Address was leased to
      mac_address: string }
    ///Creates an instance of mconnsnapshotdhcplease with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (client_id: string,
                          expiry_time: float,
                          hostname: string,
                          interface_name: string,
                          ip_address: string,
                          mac_address: string): mconnsnapshotdhcplease =
        { client_id = client_id
          connector_id = None
          expiry_time = expiry_time
          hostname = hostname
          interface_name = interface_name
          ip_address = ip_address
          mac_address = mac_address }

///Snapshot Disk
type mconnsnapshotdisk =
    { ///Connector identifier
      connector_id: Option<string>
      ///Discards completed successfully
      discards: Option<float>
      ///Discards merged
      discards_merged: Option<float>
      ///Flushes completed successfully
      flushes: Option<float>
      ///I/Os currently in progress
      in_progress: float
      ///Device major number
      major: float
      ///Reads merged
      merged: float
      ///Device minor number
      minor: float
      ///Device name
      name: string
      ///Reads completed successfully
      reads: float
      ///Sectors discarded
      sectors_discarded: Option<float>
      ///Sectors read successfully
      sectors_read: float
      ///Sectors written successfully
      sectors_written: float
      ///Time spent discarding (milliseconds)
      time_discarding_ms: Option<float>
      ///Time spent flushing (milliseconds)
      time_flushing_ms: Option<float>
      ///Time spent doing I/Os (milliseconds)
      time_in_progress_ms: float
      ///Time spent reading (milliseconds)
      time_reading_ms: float
      ///Time spent writing (milliseconds)
      time_writing_ms: float
      ///Weighted time spent doing I/Os (milliseconds)
      weighted_time_in_progress_ms: float
      ///Writes completed
      writes: float
      ///Writes merged
      writes_merged: float }
    ///Creates an instance of mconnsnapshotdisk with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (in_progress: float,
                          major: float,
                          merged: float,
                          minor: float,
                          name: string,
                          reads: float,
                          sectors_read: float,
                          sectors_written: float,
                          time_in_progress_ms: float,
                          time_reading_ms: float,
                          time_writing_ms: float,
                          weighted_time_in_progress_ms: float,
                          writes: float,
                          writes_merged: float): mconnsnapshotdisk =
        { connector_id = None
          discards = None
          discards_merged = None
          flushes = None
          in_progress = in_progress
          major = major
          merged = merged
          minor = minor
          name = name
          reads = reads
          sectors_discarded = None
          sectors_read = sectors_read
          sectors_written = sectors_written
          time_discarding_ms = None
          time_flushing_ms = None
          time_in_progress_ms = time_in_progress_ms
          time_reading_ms = time_reading_ms
          time_writing_ms = time_writing_ms
          weighted_time_in_progress_ms = weighted_time_in_progress_ms
          writes = writes
          writes_merged = writes_merged }

///Snapshot Interface
type mconnsnapshotinterface =
    { ///Connector identifier
      connector_id: Option<string>
      ip_addresses: Option<list<mconnsnapshotinterfaceaddress>>
      ///Name of the network interface
      name: string
      ///UP/DOWN state of the network interface
      operstate: string
      ///Speed of the network interface (bits per second)
      speed: Option<float> }
    ///Creates an instance of mconnsnapshotinterface with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, operstate: string): mconnsnapshotinterface =
        { connector_id = None
          ip_addresses = None
          name = name
          operstate = operstate
          speed = None }

///Snapshot Interface Address
type mconnsnapshotinterfaceaddress =
    { ///Connector identifier
      connector_id: Option<string>
      ///Name of the network interface
      interface_name: string
      ///IP address of the network interface
      ip_address: string }
    ///Creates an instance of mconnsnapshotinterfaceaddress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (interface_name: string, ip_address: string): mconnsnapshotinterfaceaddress =
        { connector_id = None
          interface_name = interface_name
          ip_address = ip_address }

type mconnsnapshotmetadata =
    { ///Time the Snapshot was collected (seconds since the Unix epoch)
      a: float
      ///Time the Snapshot was recorded (seconds since the Unix epoch)
      t: float }
    ///Creates an instance of mconnsnapshotmetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (a: float, t: float): mconnsnapshotmetadata = { a = a; t = t }

///Snapshot Mount
type mconnsnapshotmount =
    { ///Available disk size (bytes)
      available_bytes: Option<float>
      ///Connector identifier
      connector_id: Option<string>
      ///File system on disk (EXT4, NTFS, etc.)
      file_system: string
      ///Determines whether the disk is read-only
      is_read_only: Option<bool>
      ///Determines whether the disk is removable
      is_removable: Option<bool>
      ///Kind of disk (HDD, SSD, etc.)
      kind: string
      ///Path where disk is mounted
      mount_point: string
      ///Name of the disk mount
      name: string
      ///Total disk size (bytes)
      total_bytes: Option<float> }
    ///Creates an instance of mconnsnapshotmount with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (file_system: string, kind: string, mount_point: string, name: string): mconnsnapshotmount =
        { available_bytes = None
          connector_id = None
          file_system = file_system
          is_read_only = None
          is_removable = None
          kind = kind
          mount_point = mount_point
          name = name
          total_bytes = None }

///Snapshot Netdev
type mconnsnapshotnetdev =
    { ///Connector identifier
      connector_id: Option<string>
      ///Name of the network device
      name: string
      ///Total bytes received
      recv_bytes: float
      ///Compressed packets received
      recv_compressed: float
      ///Packets dropped
      recv_drop: float
      ///Bad packets received
      recv_errs: float
      ///FIFO overruns
      recv_fifo: float
      ///Frame alignment errors
      recv_frame: float
      ///Multicast packets received
      recv_multicast: float
      ///Total packets received
      recv_packets: float
      ///Total bytes transmitted
      sent_bytes: float
      ///Number of packets not sent due to carrier errors
      sent_carrier: float
      ///Number of collisions
      sent_colls: float
      ///Number of compressed packets transmitted
      sent_compressed: float
      ///Number of packets dropped during transmission
      sent_drop: float
      ///Number of transmission errors
      sent_errs: float
      ///FIFO overruns
      sent_fifo: float
      ///Total packets transmitted
      sent_packets: float }
    ///Creates an instance of mconnsnapshotnetdev with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string,
                          recv_bytes: float,
                          recv_compressed: float,
                          recv_drop: float,
                          recv_errs: float,
                          recv_fifo: float,
                          recv_frame: float,
                          recv_multicast: float,
                          recv_packets: float,
                          sent_bytes: float,
                          sent_carrier: float,
                          sent_colls: float,
                          sent_compressed: float,
                          sent_drop: float,
                          sent_errs: float,
                          sent_fifo: float,
                          sent_packets: float): mconnsnapshotnetdev =
        { connector_id = None
          name = name
          recv_bytes = recv_bytes
          recv_compressed = recv_compressed
          recv_drop = recv_drop
          recv_errs = recv_errs
          recv_fifo = recv_fifo
          recv_frame = recv_frame
          recv_multicast = recv_multicast
          recv_packets = recv_packets
          sent_bytes = sent_bytes
          sent_carrier = sent_carrier
          sent_colls = sent_colls
          sent_compressed = sent_compressed
          sent_drop = sent_drop
          sent_errs = sent_errs
          sent_fifo = sent_fifo
          sent_packets = sent_packets }

///Snapshot Thermal
type mconnsnapshotthermal =
    { ///Connector identifier
      connector_id: Option<string>
      ///Critical failure temperature of the component (degrees Celsius)
      critical_celcius: Option<float>
      ///Current temperature of the component (degrees Celsius)
      current_celcius: Option<float>
      ///Sensor identifier for the component
      label: string
      ///Maximum temperature of the component (degrees Celsius)
      max_celcius: Option<float> }
    ///Creates an instance of mconnsnapshotthermal with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (label: string): mconnsnapshotthermal =
        { connector_id = None
          critical_celcius = None
          current_celcius = None
          label = label
          max_celcius = None }

///Snapshot Tunnels
type mconnsnapshottunnel =
    { ///Connector identifier
      connector_id: Option<string>
      ///Name of tunnel health state (unknown, healthy, degraded, down)
      health_state: string
      ///Numeric value associated with tunnel state (0 = unknown, 1 = healthy, 2 = degraded, 3 = down)
      health_value: float
      ///The tunnel interface name (i.e. xfrm1, xfrm3.99, etc.)
      interface_name: string
      ///MTU as measured between the two ends of the tunnel
      probed_mtu: Option<float>
      ///Number of recent healthy pings for this tunnel
      recent_healthy_pings: Option<float>
      ///Number of recent unhealthy pings for this tunnel
      recent_unhealthy_pings: Option<float>
      ///Tunnel identifier
      tunnel_id: string }
    ///Creates an instance of mconnsnapshottunnel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (health_state: string, health_value: float, interface_name: string, tunnel_id: string): mconnsnapshottunnel =
        { connector_id = None
          health_state = health_state
          health_value = health_value
          interface_name = interface_name
          probed_mtu = None
          recent_healthy_pings = None
          recent_unhealthy_pings = None
          tunnel_id = tunnel_id }

[<RequireQualifiedAccess>]
type DeleteDnsProtectionRulesForAccount =
    ///Delete all DNS Protection rules response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListDnsProtectionRulesForAccount =
    ///List all DNS Protection rules response.
    | OK of payload: ``dosdns-protection-rule-list-response``

[<RequireQualifiedAccess>]
type CreateDnsProtectionRule =
    ///Create DNS Protection rule response.
    | OK of payload: ``dosdns-protection-rule-response``

[<RequireQualifiedAccess>]
type DeleteDnsProtectionRule =
    ///Delete DNS Protection rule response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetDnsProtectionRule =
    ///Get DNS Protection rule response.
    | OK of payload: ``dosdns-protection-rule-response``

[<RequireQualifiedAccess>]
type UpdateDnsProtectionRule =
    ///Update DNS Protection rule response.
    | OK of payload: ``dosdns-protection-rule-response``

[<RequireQualifiedAccess>]
type DeleteAllowlistPrefixesForAccount =
    ///Delete all allowlist prefixes response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListAllowlistPrefixesForAccount =
    ///List all allowlist prefixes response.
    | OK of payload: ``dosinfra-prefix-list-response``

[<RequireQualifiedAccess>]
type CreateAllowlistedPrefix =
    ///Create allowlist prefix response.
    | OK of payload: ``dosinfra-prefix-response``

[<RequireQualifiedAccess>]
type DeleteAllowlistPrefix =
    ///Delete allowlist prefix response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetAllowlistPrefix =
    ///Get allowlist prefix response.
    | OK of payload: ``dosinfra-prefix-response``

[<RequireQualifiedAccess>]
type UpdateAllowlistPrefix =
    ///Update allowlist prefix response.
    | OK of payload: ``dosinfra-prefix-response``

[<RequireQualifiedAccess>]
type DeletePrefixesForAccount =
    ///Delete all prefixes response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListPrefixesForAccount =
    ///List all prefixes response.
    | OK of payload: ``dosprefix-list-response``

[<RequireQualifiedAccess>]
type CreatePrefix =
    ///Create prefix response.
    | OK of payload: ``dosprefix-response``

type BulkCreatePrefixesPayloadArrayItem =
    { ///A comment describing the prefix.
      comment: string
      ///Whether to exclude the prefix from protection.
      excluded: bool
      ///The prefix to add in CIDR format.
      prefix: string }
    ///Creates an instance of BulkCreatePrefixesPayloadArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (comment: string, excluded: bool, prefix: string): BulkCreatePrefixesPayloadArrayItem =
        { comment = comment
          excluded = excluded
          prefix = prefix }

type BulkCreatePrefixesPayload = list<BulkCreatePrefixesPayloadArrayItem>

[<RequireQualifiedAccess>]
type BulkCreatePrefixes =
    ///Create multiple prefixes response.
    | OK of payload: ``dosprefix-list-response``

[<RequireQualifiedAccess>]
type DeletePrefix =
    ///Delete prefix response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetPrefix =
    ///Get prefix response.
    | OK of payload: ``dosprefix-response``

[<RequireQualifiedAccess>]
type UpdatePrefix =
    ///Update prefix response.
    | OK of payload: ``dosprefix-response``

[<RequireQualifiedAccess>]
type DeleteSynProtectionFiltersForAccount =
    ///Delete all SYN Protection filters response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListSynProtectionFiltersForAccount =
    ///List all SYN Protection filters response.
    | OK of payload: ``dosexpression-filter-list-response``

[<RequireQualifiedAccess>]
type CreateSynProtectionFilter =
    ///Create SYN Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type DeleteSynProtectionFilter =
    ///Delete SYN Protection filter response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetSynProtectionFilter =
    ///Get SYN Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type UpdateSynProtectionFilter =
    ///Update SYN Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type DeleteSynProtectionRulesForAccount =
    ///Delete all SYN Protection rules response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListSynProtectionRulesForAccount =
    ///List all SYN Protection rules response.
    | OK of payload: ``dossyn-protection-rule-list-response``

[<RequireQualifiedAccess>]
type CreateSynProtectionRule =
    ///Create SYN Protection rule response.
    | OK of payload: ``dossyn-protection-rule-response``

[<RequireQualifiedAccess>]
type DeleteSynProtectionRule =
    ///Delete SYN Protection rule response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetSynProtectionRule =
    ///Get SYN Protection rule response.
    | OK of payload: ``dossyn-protection-rule-response``

[<RequireQualifiedAccess>]
type UpdateSynProtectionRule =
    ///Update SYN Protection rule response.
    | OK of payload: ``dossyn-protection-rule-response``

[<RequireQualifiedAccess>]
type DeleteTcpFlowProtectionFiltersForAccount =
    ///Delete all TCP Flow Protection filters response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListTcpFlowProtectionFiltersForAccount =
    ///List all TCP Flow Protection filters response.
    | OK of payload: ``dosexpression-filter-list-response``

[<RequireQualifiedAccess>]
type CreateTcpFlowProtectionFilter =
    ///Create TCP Flow Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type DeleteTcpFlowProtectionFilter =
    ///Delete TCP Flow Protection filter response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetTcpFlowProtectionFilter =
    ///Get TCP Flow Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type UpdateTcpFlowProtectionFilter =
    ///Update TCP Flow Protection filter response.
    | OK of payload: ``dosexpression-filter-response``

[<RequireQualifiedAccess>]
type DeleteTcpFlowProtectionRulesForAccount =
    ///Delete all TCP Flow Protection rules response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type ListTcpFlowProtectionRulesForAccount =
    ///List all TCP Flow Protection rules response.
    | OK of payload: ``dostcp-flow-protection-rule-list-response``

[<RequireQualifiedAccess>]
type CreateTcpFlowProtectionRule =
    ///Create TCP Flow Protection rule response.
    | OK of payload: ``dostcp-flow-protection-rule-response``

[<RequireQualifiedAccess>]
type DeleteTcpFlowProtectionRule =
    ///Delete TCP Flow Protection rule response.
    | OK of payload: ``dosapi-response-common``

[<RequireQualifiedAccess>]
type GetTcpFlowProtectionRule =
    ///Get TCP Flow Protection rule response.
    | OK of payload: ``dostcp-flow-protection-rule-response``

[<RequireQualifiedAccess>]
type UpdateTcpFlowProtectionRule =
    ///Update TCP Flow Protection rule response.
    | OK of payload: ``dostcp-flow-protection-rule-response``

[<RequireQualifiedAccess>]
type GetProtectionStatus =
    ///Get protection status response.
    | OK of payload: ``dosprotection-status-response``

[<RequireQualifiedAccess>]
type UpdateProtectionStatus =
    ///Update protection status response.
    | OK of payload: ``dosprotection-status-response``

[<RequireQualifiedAccess>]
type MagicAccountAppsListApps =
    ///List Apps response
    | OK of payload: magicappscollectionresponse

[<RequireQualifiedAccess>]
type MagicAccountAppsAddApp =
    ///Create Account App response
    | Created of payload: magicappsingleresponse

[<RequireQualifiedAccess>]
type MagicAccountAppsDeleteApp =
    ///Delete App response
    | OK of payload: magicappsingleresponse

[<RequireQualifiedAccess>]
type MagicAccountAppsPatchApp =
    ///Update App response
    | OK of payload: magicappsingleresponse

[<RequireQualifiedAccess>]
type MagicAccountAppsUpdateApp =
    ///Update App response
    | OK of payload: magicappsingleresponse

[<RequireQualifiedAccess>]
type MagicInterconnectsListInterconnects =
    ///List interconnects response
    | OK of payload: ``magiccomponents-schemas-tunnelscollectionresponse``

[<RequireQualifiedAccess>]
type MagicInterconnectsUpdateMultipleInterconnects =
    ///Update multiple interconnects response
    | OK of payload: ``magiccomponents-schemas-modifiedtunnelscollectionresponse``

[<RequireQualifiedAccess>]
type MagicInterconnectsListInterconnectDetails =
    ///List interconnect Details response
    | OK of payload: ``magiccomponents-schemas-tunnelsingleresponse``

[<RequireQualifiedAccess>]
type MagicInterconnectsUpdateInterconnect =
    ///Update interconnect response
    | OK of payload: ``magiccomponents-schemas-tunnelmodifiedresponse``

[<RequireQualifiedAccess>]
type CatalogSyncsList =
    ///OK.
    | OK of payload: mcnreadaccountcatalogsyncsresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsCreate =
    ///Created.
    | Created of payload: mcncreatecatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsPrebuiltPoliciesList =
    ///OK.
    | OK of payload: mcncatalogsyncsprebuiltpoliciesresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsDelete =
    ///OK.
    | OK of payload: mcndeletecatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsRead =
    ///OK.
    | OK of payload: mcnreadaccountcatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsPatch =
    ///OK.
    | OK of payload: mcnupdatecatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsUpdate =
    ///OK.
    | OK of payload: mcnupdatecatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type CatalogSyncsRefresh =
    ///OK.
    | OK of payload: mcnrefreshcatalogsyncresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsList =
    ///OK.
    | OK of payload: mcnlistonrampsresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsCreate =
    ///Created.
    | Created of payload: mcncreateonrampresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsMwanAddrSpaceRead =
    ///OK.
    | OK of payload: mcngetmagicwanaddressspaceresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsMwanAddrSpacePatch =
    ///OK.
    | OK of payload: mcnupdatemagicwanaddressspaceresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsMwanAddrSpaceUpdate =
    ///OK.
    | OK of payload: mcnupdatemagicwanaddressspaceresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsDelete =
    ///OK.
    | OK of payload: mcndeleteonrampresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsRead =
    ///OK.
    | OK of payload: mcngetonrampresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsPatch =
    ///OK.
    | OK of payload: mcnupdateonrampresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsUpdate =
    ///OK.
    | OK of payload: mcnupdateonrampresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsApply =
    ///Accepted.
    | Accepted of payload: mcngoodresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsExport =
    ///Exported file.
    | Created of payload: string
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type OnrampsPlan =
    ///Accepted.
    | Accepted of payload: mcngoodresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersList =
    ///OK.
    | OK of payload: mcnreadaccountprovidersresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersCreate =
    ///Created.
    | Created of payload: mcncreateproviderresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersDiscoverAll =
    ///Accepted.
    | Accepted of payload: mcngoodresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersDelete =
    ///OK.
    | OK of payload: mcndeleteproviderresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersRead =
    ///OK.
    | OK of payload: mcnreadaccountproviderresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersPatch =
    ///OK.
    | OK of payload: mcnupdateproviderresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersUpdate =
    ///OK.
    | OK of payload: mcnupdateproviderresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersDiscover =
    ///Accepted.
    | Accepted of payload: mcngoodresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Conflict.
    | Conflict of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ProvidersInitialSetup =
    ///OK.
    | OK of payload: mcnproviderinitialsetupresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ResourcesCatalogList =
    ///OK.
    | OK of payload: mcnreadaccountresourcesresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ResourcesCatalogExport =
    ///Exported file.
    | OK of payload: string
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ResourcesCatalogPolicyPreview =
    ///OK.
    | OK of payload: mcnresourcescatalogpolicypreviewresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Unprocessable Entity.
    | UnprocessableEntity of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type ResourcesCatalogRead =
    ///OK.
    | OK of payload: mcnreadaccountresourceresponse
    ///Bad Request.
    | BadRequest of payload: mcnbadresponse
    ///Invalid Credentials.
    | Unauthorized of payload: mcnbadresponse
    ///Forbidden.
    | Forbidden of payload: mcnbadresponse
    ///Not Found.
    | NotFound of payload: mcnbadresponse
    ///Internal Server Error.
    | InternalServerError of payload: mcnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorList =
    ///OK
    | OK of payload: mconncustomerconnectorlistresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorCreate =
    ///OK
    | OK of payload: mconncustomerconnectorcreateresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Not Found
    | NotFound of payload: mconnbadresponse
    ///Conflict
    | Conflict of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorDelete =
    ///OK
    | OK of payload: mconncustomerconnectordeleteresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Not Found
    | NotFound of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorFetch =
    ///OK
    | OK of payload: mconncustomerconnectorfetchresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Not Found
    | NotFound of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorUpdate =
    ///OK
    | OK of payload: mconncustomerconnectorupdateresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Not Found
    | NotFound of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorReplace =
    ///OK
    | OK of payload: mconncustomerconnectorupdateresponse
    ///Bad Request
    | BadRequest of payload: mconnbadresponse
    ///Unauthorized
    | Unauthorized of payload: mconnbadresponse
    ///Forbidden
    | Forbidden of payload: mconnbadresponse
    ///Not Found
    | NotFound of payload: mconnbadresponse
    ///Internal Server Error
    | InternalServerError of payload: mconnbadresponse

[<RequireQualifiedAccess>]
type MconnConnectorTelemetryEventsList =
    ///OK
    | OK of payload: mconncustomereventsgetsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MconnConnectorTelemetryEventsListLatest =
    ///OK
    | OK of payload: mconncustomereventsgetlatestsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Not Found
    | NotFound of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MconnConnectorTelemetryEventsGet =
    ///OK
    | OK of payload: mconncustomereventgetsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Not Found
    | NotFound of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MconnConnectorTelemetrySnapshotsList =
    ///OK
    | OK of payload: mconncustomersnapshotsgetsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MconnConnectorTelemetrySnapshotsListLatest =
    ///OK
    | OK of payload: mconncustomersnapshotsgetlatestsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Not Found
    | NotFound of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MconnConnectorTelemetrySnapshotsGet =
    ///OK
    | OK of payload: mconncustomersnapshotgetsuccess
    ///Bad Request
    | BadRequest of payload: mconnenvelope
    ///Unauthorized
    | Unauthorized of payload: mconnenvelope
    ///Forbidden
    | Forbidden of payload: mconnenvelope
    ///Not Found
    | NotFound of payload: mconnenvelope
    ///Internal Server Error
    | InternalServerError of payload: mconnenvelope

[<RequireQualifiedAccess>]
type MagicGreTunnelsListGreTunnels =
    ///List GRE tunnels response
    | OK of payload: magictunnelscollectionresponse

[<RequireQualifiedAccess>]
type MagicGreTunnelsCreateGreTunnels =
    ///Create GRE tunnels response
    | OK of payload: magiccreategretunnelresponse

[<RequireQualifiedAccess>]
type MagicGreTunnelsUpdateMultipleGreTunnels =
    ///Update multiple GRE tunnels response
    | OK of payload: magicmodifiedtunnelscollectionresponse

[<RequireQualifiedAccess>]
type MagicGreTunnelsDeleteGreTunnel =
    ///Delete GRE Tunnel response
    | OK of payload: magictunneldeletedresponse

[<RequireQualifiedAccess>]
type MagicGreTunnelsListGreTunnelDetails =
    ///List GRE Tunnel Details response
    | OK of payload: magictunnelsingleresponse

[<RequireQualifiedAccess>]
type MagicGreTunnelsUpdateGreTunnel =
    ///Update GRE Tunnel response
    | OK of payload: magictunnelmodifiedresponse

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsListIpsecTunnels =
    ///List IPsec tunnels response
    | OK of payload: ``magicschemas-tunnelscollectionresponse``

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsCreateIpsecTunnels =
    ///Create IPsec tunnels response
    | OK of payload: ``magicschemas-createipsectunnelresponse``

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsUpdateMultipleIpsecTunnels =
    ///Update multiple IPsec tunnels response
    | OK of payload: ``magicschemas-modifiedtunnelscollectionresponse``

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsDeleteIpsecTunnel =
    ///Delete IPsec Tunnel response
    | OK of payload: ``magicschemas-tunneldeletedresponse``

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsListIpsecTunnelDetails =
    ///List IPsec tunnel details response
    | OK of payload: ``magicschemas-tunnelsingleresponse``

[<RequireQualifiedAccess>]
type MagicIpsecTunnelsUpdateIpsecTunnel =
    ///Update IPsec Tunnel response
    | OK of payload: ``magicschemas-tunnelmodifiedresponse``

[<RequireQualifiedAccess>]
type ``MagicIpsecTunnelsGeneratePreSharedKey(Psk)ForIpsecTunnels`` =
    ///Generate Pre Shared Key (PSK) for IPsec tunnels response
    | OK of payload: magicpskgenerationresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesDeleteManyRoutes =
    ///Delete Many Routes response
    | OK of payload: magicmultipleroutedeleteresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesListRoutes =
    ///List Routes response
    | OK of payload: magicroutescollectionresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesCreateRoutes =
    ///Create Routes response
    | OK of payload: magiccreaterouteresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesUpdateManyRoutes =
    ///Update Many Routes response
    | OK of payload: magicmultipleroutemodifiedresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesDeleteRoute =
    ///Delete Route response
    | OK of payload: magicroutedeletedresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesRouteDetails =
    ///Route Details response
    | OK of payload: magicroutesingleresponse

[<RequireQualifiedAccess>]
type MagicStaticRoutesUpdateRoute =
    ///Update Route response
    | OK of payload: magicroutemodifiedresponse

[<RequireQualifiedAccess>]
type MagicSitesListSites =
    ///List Sites response
    | OK of payload: magicsitescollectionresponse

[<RequireQualifiedAccess>]
type MagicSitesCreateSite =
    ///Create Site response
    | OK of payload: magicsitesingleresponse

[<RequireQualifiedAccess>]
type MagicSitesDeleteSite =
    ///Delete Site response
    | OK of payload: magicsitedeletedresponse

[<RequireQualifiedAccess>]
type MagicSitesSiteDetails =
    ///Site Details response
    | OK of payload: magicsitesingleresponse

[<RequireQualifiedAccess>]
type MagicSitesPatchSite =
    ///Patch Site response
    | OK of payload: magicsitemodifiedresponse

[<RequireQualifiedAccess>]
type MagicSitesUpdateSite =
    ///Update Site response
    | OK of payload: magicsitemodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsListAcls =
    ///List Site ACLs response
    | OK of payload: magicaclscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsCreateAcl =
    ///Create Site ACL response
    | OK of payload: magicaclsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsDeleteAcl =
    ///Delete Site ACL response
    | OK of payload: magicacldeletedresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsAclDetails =
    ///Site ACL Details response
    | OK of payload: magicaclsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsPatchAcl =
    ///Patch Site ACL response
    | OK of payload: magicaclmodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteAclsUpdateAcl =
    ///Update Site ACL response
    | OK of payload: magicaclmodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteAppConfigsListAppConfigs =
    ///List App Configs response
    | OK of payload: magicappconfigscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteAppConfigsAddAppConfig =
    ///Create Site App Config response
    | Created of payload: magicappconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteAppConfigsDeleteAppConfig =
    ///Delete App Config response
    | OK of payload: magicappconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteAppConfigsPatchAppConfig =
    ///Update Site App Config response
    | OK of payload: magicappconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteAppConfigsUpdateAppConfig =
    ///Update Site App Config response
    | OK of payload: magicappconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteLansListLans =
    ///List Site LANs response
    | OK of payload: magiclanscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteLansCreateLan =
    ///Create Site LAN response
    | OK of payload: magiclanscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteLansDeleteLan =
    ///Delete Site LAN response
    | OK of payload: magiclandeletedresponse

[<RequireQualifiedAccess>]
type MagicSiteLansLanDetails =
    ///Site LAN Details response
    | OK of payload: magiclansingleresponse

[<RequireQualifiedAccess>]
type MagicSiteLansPatchLan =
    ///Patch Site LAN response
    | OK of payload: magiclanmodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteLansUpdateLan =
    ///Update Site LAN response
    | OK of payload: magiclanmodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteNetflowConfigDeleteNetflowConfig =
    ///Delete NetFlow Configuration response
    | OK of payload: magicnetflowconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteNetflowConfigDetails =
    ///Get NetFlow Configuration response
    | OK of payload: magicnetflowconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteNetflowConfigPatchNetflowConfig =
    ///Update NetFlow Configuration response
    | OK of payload: magicnetflowconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteNetflowConfigCreateNetflowConfig =
    ///Create NetFlow Configuration response
    | Created of payload: magicnetflowconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteNetflowConfigUpdateNetflowConfig =
    ///Update NetFlow Configuration response
    | OK of payload: magicnetflowconfigsingleresponse

[<RequireQualifiedAccess>]
type MagicSiteWansListWans =
    ///List Site WANs response
    | OK of payload: magicwanscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteWansCreateWan =
    ///Create Site WAN response
    | OK of payload: magicwanscollectionresponse

[<RequireQualifiedAccess>]
type MagicSiteWansDeleteWan =
    ///Delete Site WAN response
    | OK of payload: magicwandeletedresponse

[<RequireQualifiedAccess>]
type MagicSiteWansWanDetails =
    ///Site WAN Details response
    | OK of payload: magicwansingleresponse

[<RequireQualifiedAccess>]
type MagicSiteWansPatchWan =
    ///Patch Site WAN response
    | OK of payload: magicwanmodifiedresponse

[<RequireQualifiedAccess>]
type MagicSiteWansUpdateWan =
    ///Update Site WAN response
    | OK of payload: magicwanmodifiedresponse
