

CREATE VIEW GetVisitStatus AS (


SELECT [Patient] = p.FirstName + SPACE(1) + p.LastName
     , [Provider] = pro.FirstName + SPACE(1) + pro.LastName
	 , [Procedure] = v.[Procedure]
	 , [Status] = vc.[name]
FROM [Visit] v
JOIN [Patient] p ON v.PatientId = p.Id
JOIN [Provider] pro ON pro.Id = v.ProviderId
LEFT JOIN [VisitStatus] vs ON vs.VisitId = v.Id
LEFT JOIN [VisitCode] vc ON vc.Id = vs.VisitCodeId

)