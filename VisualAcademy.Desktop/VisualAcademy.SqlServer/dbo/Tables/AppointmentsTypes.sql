CREATE TABLE [dbo].[AppointmentsTypes]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1),
	[AppointmentTypeName] NVARCHAR(50) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [DataCreated] DATETIME NOT NULL DEFAULT GETDATE()
)
