# ContactsManagerApp
Sample Application in MVC 5 using REST APIs
This application is developed in MVC 5 using Microsoft Visual Studio 2017 and .Net Framework 4.6.1
This is an application which manages the contacts and has the following features:
      1. Create New Contact
      2. List Existing Contacts
      3. Edit a Contact
      4. Delete a Contact
      5. Mark the Contact as Active or In-active
It uses a Web Api Controller i.e. ContactsApiController for iteracting with the to DB server. its a REST API with will be consumed by the Web Client
The client used for making REST calls to the ContactsApi and getting JSON response is ContactsClient. 
The JSON Response is serialized as Model Object(s) of Model i.e. Contacts
Also, the Model used for DBContext is ContactsManagerAppContext
Controller i.e. ContactsController is used for managing the views created for managing Contacts
Views created for managing contacts are Index, Create, Edit, Delete
Also, shared views are used for the common layout and error for all the views.

You can download the code and run it locally for it to work.

Also, when using IIS Express add both of these bindings to your site as:

                  <bindings>
                        <binding protocol="http" bindingInformation="*:1562:localhost" />
                        <binding protocol="http" bindingInformation="*:1562:127.0.0.1" />
                        
                </bindings>
                
As, the unit test project created for this application, the REST calls from the unit tests to the REST api will not be resolving hostname to local ip unless the binding is done even for the local ip i.e. 127.0.0.1 alongwith the host name i.e. localhost in applicationhost.config file when run locally unless hosted online.

