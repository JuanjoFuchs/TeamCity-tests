"C:\Program Files (x86)\NUnit\bin\nunit-console-x86.exe" /labels /out=TestResult.txt /xml=TestResult.xml /framework=net-4.0 CodeBreaker2.Specs\bin\debug\CodeBreaker2.Specs.dll
"C:\Program Files (x86)\TechTalk\SpecFlow\specflow.exe" nunitexecutionreport CodeBreaker2.Specs\CodeBreaker.Specs.csproj"

IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT

:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1