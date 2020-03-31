# RealTimeApi
This is our attempt to put together a base for what we see as an api that could be helpful for communication between our platforms.

Out of the box, this code base comes with swagger - which is a web-based way of accessing and testing an api.

To use swagger, simply build the project and navigate to: https://localhost:44327/swagger

The meat of the code is in the controllers folder.  You would simply alter the methods there.  Most of the signatures and even the return types would need to be changed.  Here are some of our thoughts on the particular controllers

**Controllers/EmployeeController.cs**
>Our thought is that this can replace the nurse/employee import and update processes where we are currently submitting this data via api.  
> Additionally it would be helpful to be able to perform "get" operations in order to see the data that realtime has for a nurse/employee
>
> Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<Employee>  but I don't know what your employee object looks like.
> Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
> right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
> 
> In the same way the post and put objects need to change from strings to the appropriate object values

**Controllers/PaymentController.cs**
> Our goal here is to use this method to generate a payment request.  This would replace the current hours import, and potentially be used for requesting pay advances.
> Additionally it would be helpful to be able to perform "get" operations in order to see the data that realtime has for a payment request.
> 
> Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<SomethingElse>  but I don't know what your employee object looks like.
> Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
> right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write


**Controllers/InvoiceController.cs**
> Our thought here would be to get invoice information that has been generated.
> 
> Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<Invoice>  but I don't know what your employee object looks like.
> Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
> right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
> 

	
**Controllers/BranchesController.cs**
> Our thought here was just to get data for a branch.  This is a lower priority
> 
> Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<Branch>  but I don't know what your employee object looks like.
> Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
> right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
    

**Controllers/CustomerController.cs**
> Our thought here was just to get data for what we call a facility.  It would be helpful to get pay and bill rates.  This is a lower priority
> 
> Obviously the method signatures need to change from IEnumerable<string> to IEnumerable<SomethingElse>  but I don't know what your employee object looks like.
> Alternative entity framework (if you're using it) can scaffold up controllers like this for get / post /put operations by 
> right clicking controllers->Add->Controller-> and then choosing the option to use entity framework with read/write
> 

