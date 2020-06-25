open Farmer
open Farmer.Builders

let developmentEnvironment = vm {
    name "dev-jan"
    username "jan"
    vm_size Vm.Standard_F8s_v2
    operating_system Vm.WindowsServer_2019Datacenter
    os_disk 128 Vm.StandardSSD_LRS
    add_ssd_disk 512
}

let deployment = arm {
    location Location.WestEurope
    add_resource developmentEnvironment
}

deployment 
|> Writer.quickWrite "..\\deployment\\development-environment"