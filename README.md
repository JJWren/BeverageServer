# Drinks Assessment

Assessment of OOP skills, etc. completed for SMARTCop

### Author: Joshua Wren

##### Creation: 13 Feb 2021
##### Updated On: 23 Oct 2023

### Title: Beverage Server

1. THE ASSESSMENT:

#### The goal of this console application was to:

-   demonstrate object-oriented skills
-   demonstrate normal coding standards (naming conventions, etc)

#### The application needed to:

-   display information about three drink types
    -   drink types:
    -   beer
    -   soda
    -   juice
-   drink types must be derived from common drink object with base fields/properties
    -   drink type base fields/properties:
    -   name
    -   carbonated or not
    -   description
    -   juice must have string property indicating fruit it is made from
    -   beer must have alcohol content
-   Add at least three drink types to a list or array
    -   one must display that it is:
        -   Orange Juice
        -   not carbonated
        -   of juice typing
    -   one must display that it is:
        -   Budweiser
        -   carbonated
        -   alcohol content
        -   of beer typing
    -   one must display that it is
        -   Pepsi
        -   carbonated
        -   of soda typing
-   List must be looped to output description of each drink
-   Allowed to include additional features

---

2. HOW I ACCOMPLISHED:

I completed all of the taskings stated above.
Since additional features were allowed:
    - I split each drink into its own child class -- deriving from a parent base class.
    - I organized the files into easily identifiable pieces.
    - I utilized a Factory Design Pattern for "serving" the drinks.
    - Extended the string class to bannerize strings for more readable console output.
