# Repo1
For HelloWorld test
Please note the following details-
1)OurHostingApp - This is a webAPI project which is the starting point for this entire solution . Here the get method (api/values/5) calls the another library project (HostAPI)

2)HostAPI(This is a library ) has the logic to call differnt types of applications depending upon the input provided by user . Please note OurHostingApp internally calls HostAPI

3)This HostAPI has a class InvokingClass which calls different  applications

4)TargetConsoleApplication is the Console application which is one of the applcations mentioned in the Question. THis is completely separate from the API code

4) Test cases - APITest.cs under HostAPI contains 2 test cases to test the Console application invocation . These test cases test the HostAPI .


