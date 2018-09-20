using System;
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
                    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
                    

                    INSERT INTO [dbUsers] (dbUsername,dbPassword,intSecurity,dtDateCreated,intActive)
                    SELECT 'Administrator','letmein',0,GETDATE(),0

        ";
    }
}
