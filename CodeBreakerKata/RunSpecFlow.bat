"C:\Program Files (x86)\NUnit\bin\nunit-console-x86.exe" /labels /out=SpecFlowResult.txt /xml=SpecFlowResult.xml /framework=net-4.0 CodeBreaker2.Specs\bin\debug\CodeBreaker.Specs.dll
"C:\Program Files (x86)\TechTalk\SpecFlow\specflow.exe" nunitexecutionreport CodeBreaker2.Specs\CodeBreaker.Specs.csproj"

IF NOT EXIST SpecFlowResult.xml GOTO FAIL
IF NOT EXIST SpecFlowResult.html GOTO FAIL
EXIT

:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1