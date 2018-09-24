﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbWizard.SQL_Scripts
{
    public class dbWizardSetup
    {
        public static string dbSetup { get; set; } = @"
 
                    USE [dbWizard]
                    

                    SET ANSI_NULLS ON
                    

                    SET QUOTED_IDENTIFIER ON
                    

                    CREATE TABLE [dbo].[dbUsers](
	                    [dbUserID] [int] IDENTITY(1,1) NOT NULL,
	                    [dbUsername] [varchar](20) NOT NULL,
	                    [dbPassword] [varchar](max) NOT NULL,
	                    [intSecurity] [int] NOT NULL,
	                    [dtDateCreated] [datetime] NOT NULL,
	                    [intActive] [int] NOT NULL
                    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
                    
                    CREATE TABLE [dbo].[dbUserGroups](
	                    [dbGroupID] [int] IDENTITY(1,1) NOT NULL,
	                    [dbGroupAlias] [varchar](20) NOT NULL,
	                    [dbGroupRights] [varchar](30) NOT NULL,
	                    [dtDateCreated] [datetime] NOT NULL
                    ) 
                    
                    CREATE TABLE [dbo].[dbUserProfile](
	                    [dbUserId] [int] NULL,
	                    [dbForename] [varchar](max) NULL,
	                    [dbSurname] [varchar](max) NULL,
	                    [dtDateOfBirth] [varchar](max) NULL,
	                    [dbEmailAddress] [varchar](max) NULL,
	                    [dbCountry] [varchar](max) NULL
                    ) 

                    INSERT INTO [dbUserGroups] (dbGroupAlias,dbGroupRights,dtDateCreated)
                    SELECT 'Admins','All',GETDATE();

                    INSERT INTO [dbUsers] (dbUsername,dbPassword,intSecurity,dtDateCreated,intActive)
                    SELECT 'Administrator','letmein',1,GETDATE(),0;

                    INSERT INTO [dbUserProfile] (dbUserId,dbForename,dbSurname,dtDateOfBirth,dbEmailAddress,dbCountry)
                    SELECT 1,NULL,NULL,NULL,NULL,NULL;

        ";
    }
}
