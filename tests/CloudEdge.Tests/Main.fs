module Fidelity.CloudEdge.Tests.Main

open System
open Expecto

[<EntryPoint>]
let main args =
    let allTests =
        testList "All Fidelity.CloudEdge Tests" [
            CoreTests.tests
            ManagementTests.tests
            RuntimeTests.tests
            DeploymentTests.tests
            GenerationTests.tests
            ClientConstructionTests.tests
            SerializationTests.tests
            InfrastructureTests.tests
        ]

    runTestsWithCLIArgs [] args allTests
