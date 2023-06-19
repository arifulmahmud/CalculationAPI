# CalculationAPI
Assignment project

This API is to check sum of given intergers and check if the sum or given number is Prime.

### Run CalculationAPI project

CalculationAPI, is build with Asp.Net web api 2.0. Exposes [api/calc] for sending action type and numbers. Only supported method is Get, and the parameters are send as part of the URL. <HOST_URL>/api/calc?action=sumandcheck&numbers=1,2,3

### Run CalculationClientApp project

CalculationClientApp is a simple React app for demonstrating the usages of CalculationAPI endpoint. It's currently consuming the live API endpoint running at : http://calcwebapi.azurewebsites.net/api/calc in Azure.
