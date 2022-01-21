# Hackathon2022
Repository for ModMed 2022 Hackathon



Notes for Exscribe Setup:  
Created a new patient in Exscribe.  
**First Name:** Thomas  
**Last Name:** Shelby  
**AccountNumber:** PEAKY  
**DoB:** 1890-05-25  
**PatientID(GENERATED ON CREATION):** 3073  

Created new appointment:  
**Patient:** Shelby, Thomas  
**Date:** 2022-01-21  
(everything else is irrelevant)  

Added items to Visit State UserList:  
Intake  
PreOp  
InOR  
Recovery  
Ready For Family  

Ran the following scripts on PatientTrackingBoardDB:  
*NOTE* If creating from scratch, ensure that all IDs match correctly as they may be different!
```
insert into Patient(Id, FirstName, LastName, DOB, SourceId, DateCreated, DateModified)
VALUES('636ea8f2-20d6-4344-aba1-ecb6dfb754fe', 'Thomas', 'Shelby', '1890-05-25', '3073', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
  
insert into Visit(id, PatientId, ProviderId, [Procedure], VisitDate, DateCreated, DateModified)
VALUES('1391fb5f-cb12-4d36-85a0-38a1091ff0d7','636EA8F2-20D6-4344-ABA1-ECB6DFB754FE', '1F7DE8ED-DD45-47B4-9022-6DED1A759E96', 'Phacoemulsification', '2022-01-21', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP )
  
insert into VisitStatus(id, VisitId, VisitCodeId, DateCreated, DateModified)
VALUES('c5f41fec-70c8-4d98-8f79-b8d102c7a2bf', '1391FB5F-CB12-4D36-85A0-38A1091FF0D7', '72AF53B9-AC43-4747-B90B-0D6D2CE8ED8A', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)
  
```  
  
  Added the following code in the EHR in the `AppointmentDataAccessLayer`'s `UpdateAppointment(DataChangeContext context, UpdateAppointmentModel appointment)` function after the visitState is set inside the `if (appointment.HasVisitStateIDChanged)` statment
  (around line 410):
  
```
var url = $"https://localhost:5001/api/VisitStatus/UpdateVisitCode/{patientEncounter.PatientId}/" +
                    $"{patientEncounter.EncounterDate.Year}-{patientEncounter.EncounterDate.Month}-{patientEncounter.EncounterDate.Day}/{visitState}";

var request = System.Net.WebRequest.Create(url);
request.Method = "GET";

var response = request.GetResponse();
    
```
