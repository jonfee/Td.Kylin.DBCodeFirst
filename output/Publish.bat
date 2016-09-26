echo off
cd .
nuget push Td.Kylin.EnumLibrary.Mono.1.6.0.nupkg -s http://192.168.1.200:8080/nuget 123456
pause