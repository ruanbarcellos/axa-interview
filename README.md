# AXA - .NET Interview Exercise

## Candidate
<div style="background-color:white;color:black">
    <p>Name: Ruan Guimarães Barcellos</p>
    <p>E-mail: <a href="mailto:ruan.gbarcellos@gmail.com">ruan.gbarcellos@gmail.com</a></p>
    <p>
        Links:
        <a href="https://github.com/ruanbarcellos"><img src="https://github.githubassets.com/images/modules/logos_page/GitHub-Logo.png" alt="Github Logotype" style="max-height:20px"></a>
        <a href="https://www.linkedin.com/in/ruanbarcellos/" style="margin-left:10px"><img src="https://content.linkedin.com/content/dam/me/business/en-us/amp/brand-site/v2/bg/LI-Logo.svg.original.svg" alt="LinkedIn logotype" style="max-height:23px"></a>
    </p>
</div>



## Project Design
<div style="background-color:white;width:100%;padding:10px">
    <img src="./AXA.png" alt="design" style="vertical-align: top;"/>
</div>

<br >

## Adding a get account balance function:
First you will need to:
 - Add a the new function signature to the ITransactionService interface.
 - Add its implementation to the TransactionService service.
 - Add a new function endpoint to the AccountController controller.

Once all functions and signatures has been created, you can now add the logic to the newly created function on the TransactionService.

<br >

## Positives characteristics of the solution:
 - No extra dependencies (full .NET core)
 - future-proof (by using dependency injection and .net core built in dependency containers, we can easily change any implementation by using its interfaces).
 - Testable
 - easy and simple to use