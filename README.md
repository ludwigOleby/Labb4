# Labb4

[GET]  
Hämta alla personer i systemet

https://localhost:44369/api/Person


[GET]
Hämta alla intressen som är kopplade till en specifik person

https://localhost:44369/api/Interest/1/interest


[GET]
Hämta alla länkar som är kopplade till en specifik person

https://localhost:44369/api/Website/2/websites

[PUT]
Koppla en person till ett nytt intresse

https://localhost:44369/api/Interest/1/update

{
    "interestID": 1,
    "interestName": "F#",
    "details": "The fine art of making F# console applications",
    "person": null,
    "personID": 1,
    "websites": null
}

[POST]
Lägga in nya länkar för en specifik person och ett specifikt intresse

https://localhost:44369/api/Website/3/updateweb


{
    "webpage": "www.google.se",
    "interests": null,
    "persons": {
        "firstName": "Sara",
        "lastName": "Sarasson",
        "phoneNr": "0736004657",
        "interests": null
    },
    "personID": 2
}


