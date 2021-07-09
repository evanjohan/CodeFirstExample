--Department
--==========================
  insert into Department(DepartmentNo,DepartmentName,CreatedBy,CreatedTime,RowStatus)
  values 	('001','IT Development','SYSTEM',GETDATE(),0),
			('002','Sales','SYSTEM',GETDATE(),0)
		  
		  
--Employee
--===========================
  Insert into Employee(EmployeeNo,EmployeeName,EmployeeAddress,DepartmentID,CreatedBy,CreatedTime,RowStatus)
  Values 	('001IT6654','Darlin','Jalan kesuma',1,'SYSTEM',GETDATE(),0),
			('001IT6654','Albert','Jalan Meruya',1,'SYSTEM',GETDATE(),0),
			('001IT6654','Dino','Jalan kelapa gading',2,'SYSTEM',GETDATE(),0)
		  


==========================
--dotnet ef migrations script -o D:\scripts.sql -i