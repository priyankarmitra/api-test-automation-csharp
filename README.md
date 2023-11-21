
# Welcome to the Cinemo trial day!

## Starting the server
Open a terminal and run `python3 webserver.py` from the project directory

This will create a webserver listening on [http://127.0.0.1:5000](http:127.0.0.1:5000)

## Usage
* Once you navigate to the url click sign up and enter in your credentials.
* After sign up you can log in with those credentials.
* Logging in will display a list of registered users.
* The only action you have available is to delete users.

## Task 1 of 2
Use a Selenium Webdriver (Python is preferable) to automate the use cases below. Ensure that you validate the use case properly.

### User story 1:
`As an unregistered user, I would like to register as a new account.`
> **Acceptance criteria:** 
> * A new user is registered and is stored in the database with the given credentials. 
> * Each new user will receive an _id_ which is unique to that user
>> <br/> 

### User story 2:

`As a registered user, I want to login to the system using the credentials that I registered with.`
>**Acceptance criteria:**
>* A registered user is able to login with the registration credentials succesfully. 
>* Once logged in, the user list screen is displayed.
>> <br/> 

### User story 3: 
`As a logged in user, I want to be able to delete other users from the system`
>**Acceptance criteria:**
>* From the user list screen, clicking the delete button will delete a user from the list.
>* The list is auto updated and the user is no longer visible
>* The deleted user can no longer log in.
>> <br/> 

**Task 2:**

There is an API available as well which should also be tested.

>_/login_ **(POST)**
>
>|parameter|type|
>|--|--|
>|email|string|
>|password|string|
>* content-type: form-data
>* Reponse: (one of the following)
>>* `User with that email already exists`
>>* `User signed up successfully! <br> <a href= />Log in</a>`
>> <br/> 
> <br/> 

>_/usersapi_ **(GET)**
>* Response:
    JSON object array with registered users
>   ```
>   [
>      {
>         "email": string
>         "id": int
>      "password": string
>      },...
>   ]
>   ```
>   <br/> 

>_/delete/**{id}**_ **(POST)**
>* content-type:: NA
>* Reponse:JSON object: (one of the following)
>
>   ```
>   {
>        "success": true
>   }
>   or
>   {
>        "error": "No user with that id",
>        "success": false
>   }
>   ```
>   <br/> 

#### _*Notes*_:

* Some defects or bad coding practices are there by design and others are there because I wrote this on a lazy Sunday afternoon.
* You may not have enough time to do all of it. If that's the case, make sure you have at least some examples of both the UI automation as well as the api testing for both positive and negative test cases
* Finally, you'll present your solution to the interview panel at the end.
* Use the internet as much as you like :)

Good luck!

Shamir 
