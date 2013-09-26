Before you open run this sample code, you must registor a developer account and get the permision to connect  iHealth. You will receive an email which contains the KEY list when website master approve your request for your application.
The steps to run the sample:
1¡¢	Open the solution file ¡¯ DeveloperAPISample.sln¡¯
2¡¢	Modify the Key list in the ¡®ConnectToiHealthlabs.cs¡¯ file bwtween line 14 to line 21 (in the ¡®Library¡¯ project),
public string client_id = " your Client ID ";
public string client_secret = "your Client Secret";
public string redirect_uri = "Your redirect Uri must contain your redirect domain ";
public string sc = "your sc";
public string sv_bp = "your SV of OpenApiBP ";
public string sv_weight = " your SV of OpenApiWeight ";

3¡¢	Build the solution.
4¡¢	Begin the web with page ¡®GetStarted.aspx¡¯
