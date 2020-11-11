# RANDOMUSER C# library


## Overview
This library gets what randomuser api returns in JSON format, and converts it to C# objects.
It supports all of the returned data the API returns in JSON. 

## Returned Data with example output

- Seed: b19d5a8714e28639, Results: 1, Page: 1, Version: 1.3
- Gender: female
- Name
  * Title: Ms
  * First: Jamie
  * Last: Carpenter
- Location:
  * Street:
      * Number: 8914
      * Name: Forest Ln
  * City: Coffs Harbour
  * State: Tasmania
  * Country: Australia
  * Postcode: 9257
  * Coordinates:
      * Latitude: -82.9795
      * Longitude: 18.7101
  * Timezone:
      * Offset: -7:00
      * Description: Mountain Time (US & Canada)
- Email: jamie.carpenter@example.com
- Login:
  * Uuid: 62d3e44a-83db-45f9-8d67-b7c22fb9ba3f
  * Username: lazypanda502
  * Password: gordo
  * Salt: nZTx9JFY
  * Md5: 710471c9ebd55118fac3ea476ded3a0f
  * Sha1: f553d8dd013bff5a5403bc7ccf70cd01a416246a
  * Sha256: 58efa2d534a8e694e2d2608b6756429dc5b8fa446cccd6f69ac69f0caed7ccb3
- Dob:
  * Date: 18.10.1986. 7:51:40
  * Age: 34
- Phone: 09-6576-2902
- Cell: 0406-612-693
- Id:
  * Name: TFN
  * Value: 471311513
- Picture:
  * Large: https://randomuser.me/api/portraits/women/16.jpg
  * Medium: https://randomuser.me/api/portraits/med/women/16.jpg
  * Medium: https://randomuser.me/api/portraits/thumb/women/16.jpg
- Nat: AU

## Installing
1. Clone this code 
  * ```$ git clone https://github.com/marijoblaz/randomuser-API-CSharp-Library.git```
2. Open the code in VS
3. Build the code base
4.  In your project that's using this code, reference the built DLL from the previous step:
    * Project dropdown -> Add Reference -> Search for the created DLL(s) file. randomuser.dll 
    * You may also need to reference the Newtonsoft.Json.dll if you aren't already using this library.
    
## Example usage

```csharp
randomuser.Query randomuserQuery = new randomuser.Query();
Console.WriteLine(randomuserQuery.Info);
foreach (var results in randomuserQuery.Results)
{
  console.WriteLine(results);
}
```
## Sample Project
This repository also has a sample project. Find it [here](https://github.com/marijoblaz/randomuser-API-CSharp-Library/tree/master/randomuserExample)!

## Query Parameters
More on [randomuser.me official website](https://randomuser.me/documentation)
### Requesting Multiple Users
"Random User Generator allows you to fetch up to 5,000 generated users in one request using the results parameter" [source](https://randomuser.me/documentation#multiple).

```csharp
//This will give you 10 random users
randomuser.Query randomuserQuery = new randomuser.Query("results=10");
```
### Specifying a gender
"You can specify whether you would like to have only male or only female users generated" [source](https://randomuser.me/documentation#gender).
```csharp
//This will give you female user
randomuser.Query randomuserQuery = new randomuser.Query("gender=female");
```
### Seeds
"Seeds allow you to always generate the same set of users." [source](https://randomuser.me/documentation#seeds).

```csharp
//This will always give you same user
randomuser.Query randomuserQuery = new randomuser.Query("seed=blabla");
```

## Credits, built with
- [randomuser](https://randomuser.me/)
- [Newtonsoft Json.NET](https://www.newtonsoft.com/json)

## License
MIT  © [Marijo Blazevic](https://opensource.org/licenses/MIT)
