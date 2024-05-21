USE [BGHAmbulance]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_AddUpdateUserRole] (@user varchar(50), @role varchar(50))
AS
BEGIN
	
	insert into dbo.AspNetUserRoles
	select @user, @role
END