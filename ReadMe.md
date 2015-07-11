# FootprintsLib

A .NET DLL that can be used to create/edit tickets with BMC Footprints (version 11.x.x). The application uses the Footprints WEB API to edit and create tickets. This library can be used to integrate Footprints with other internal tools/applications.

An example of how his can be used can be found in the scripts directory where you'll see a Powershell script that uses this library to create a ticket with the appropriate information (i.e. priority, status, etc.). This script was then setup thru a scheduled job to run every Friday at 8:00 a.m. and a ticket was generated if any expired users were found in the specified OU. 
