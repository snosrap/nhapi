set BASE=d:\projects\nHapi\Nhapi20
set MSBUILD=C:\WINDOWS\Microsoft.NET\Framework\v3.5\MSBUILD.exe
cd %BASE%
d:
cd modelgenerator
cd bin
cd debug
modelgenerator.exe %BASE% 2.3.UCH
cd %BASE%
%msbuild% UCH.sln

