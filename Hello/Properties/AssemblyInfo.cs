﻿< Target Name = "BeforeBuild" >

   < ItemGroup >

     < AssemblyAttributes Include = "AssemblyVersion" >

        < _Parameter1 >$(Version) </ _Parameter1 >

        </ AssemblyAttributes >

      </ ItemGroup >

      < MakeDir Directories = "$(IntermediateOutputPath)" />

       < WriteCodeFragment Language = "C#"
                     OutputFile = "$(IntermediateOutputPath)Version.cs"
                     AssemblyAttributes = "@(AssemblyAttributes)" />
  < ItemGroup >
    < Compile Include = "$(IntermediateOutputPath)Version.cs" />

   </ ItemGroup >
 </ Target >