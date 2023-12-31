USE [PATIENTS]
GO
/****** Object:  Table [dbo].[clerk_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clerk_details](
	[Clerk_Id] [varchar](20) NOT NULL,
	[Clerk_Name] [varchar](20) NULL,
	[Password] [varchar](50) NULL,
	[age] [int] NULL,
	[Gender] [varchar](10) NULL,
	[Address] [varchar](100) NULL,
	[Date_of_Joining] [date] NULL,
	[Email_Id] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Clerk_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor_details](
	[doctor_Id] [varchar](20) NOT NULL,
	[doctor_Name] [varchar](20) NULL,
	[age] [int] NULL,
	[Experience] [int] NULL,
	[Qualification] [varchar](100) NULL,
	[Address] [varchar](1000) NULL,
	[Contact_No] [bigint] NULL,
	[Email_Id] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[doctor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[feedback_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback_details](
	[prescription_id] [varchar](20) NOT NULL,
	[consultation_date] [datetime] NULL,
	[doctor_name] [varchar](20) NULL,
	[problem_description] [varchar](20) NULL,
	[additional_notes] [varchar](500) NULL,
	[feedback_detailscol] [varchar](45) NULL,
	[prescription_details_patient_id] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[prescription_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine_bill]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine_bill](
	[Cc_Number] [int] NOT NULL,
	[patient_id] [varchar](20) NULL,
	[doctor_name] [varchar](20) NULL,
	[consul_date] [datetime] NULL,
	[prescription_id] [varchar](20) NULL,
	[doctor_Id] [varchar](20) NULL,
	[date_of_prescription] [date] NULL,
	[medicine_id] [varchar](20) NULL,
	[Patient_No] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cc_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine_details](
	[medicine_id] [varchar](20) NOT NULL,
	[medicine_name] [varchar](20) NULL,
	[company_name] [varchar](300) NULL,
	[medicine_type] [varchar](50) NULL,
	[storage_type] [varchar](10) NULL,
	[quantity] [int] NULL,
	[price_per_unit] [int] NULL,
	[manufacture_date] [date] NULL,
	[expiry_date] [date] NULL,
	[doctor_Id] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_details](
	[Patient_No] [varchar](20) NOT NULL,
	[Patient_Name] [varchar](20) NULL,
	[age] [int] NULL,
	[Address] [varchar](100) NULL,
	[Gender] [varchar](20) NULL,
	[Contact_No] [bigint] NULL,
	[Email_Id] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Patient_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prescription_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prescription_details](
	[prescription_id] [varchar](20) NULL,
	[prescription_date] [date] NULL,
	[doctor_id] [varchar](20) NULL,
	[patient_No] [varchar](20) NULL,
	[medicine_id] [varchar](20) NULL,
	[problem_description] [varchar](700) NULL,
	[prescribed_medicine_name] [varchar](300) NULL,
	[alternative_medicine_name] [varchar](20) NULL,
	[quantity_to_purchase] [int] NULL,
	[dosage] [int] NULL,
	[duration] [varchar](20) NULL,
	[add_note] [varchar](100) NULL,
	[next_consaltation_date] [datetime] NULL,
	[consaltation_id] [varchar](200) NULL,
	[patient_id] [varchar](20) NOT NULL,
	[medicine_bill_cc_number] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_details]    Script Date: 17/07/2023 11:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[user_id] [varchar](20) NULL,
	[user_name] [varchar](20) NULL,
	[user_type] [varchar](50) NULL,
	[user_psw] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[clerk_details] ([Clerk_Id], [Clerk_Name], [Password], [age], [Gender], [Address], [Date_of_Joining], [Email_Id]) VALUES (N'CLE1901227471', N'Anjali Gupta', N'CLE0040@', 22, N'Female', N'Sector 21 Rajiv Ghadndhi Chowk New Delhi', CAST(N'2023-06-05' AS Date), N'cle471@gmail.com')
INSERT [dbo].[clerk_details] ([Clerk_Id], [Clerk_Name], [Password], [age], [Gender], [Address], [Date_of_Joining], [Email_Id]) VALUES (N'CLE1901227472', N'Ayush Kumar', N'CLE0030@', 23, N'Male', N'Williomson Towns New Delhi', CAST(N'2023-02-28' AS Date), N'cle472@gmail.com')
INSERT [dbo].[clerk_details] ([Clerk_Id], [Clerk_Name], [Password], [age], [Gender], [Address], [Date_of_Joining], [Email_Id]) VALUES (N'CLE1901227504', N'Harshit Kumar', N'CLE0010@', 32, N'Male', N'Sector 34 Janpath Road New Delhi', CAST(N'2023-02-28' AS Date), N'cle504@gmail.com')
INSERT [dbo].[clerk_details] ([Clerk_Id], [Clerk_Name], [Password], [age], [Gender], [Address], [Date_of_Joining], [Email_Id]) VALUES (N'CLE1901227512', N'Nausin Nigar', N'CLE0020@', 21, N'Female', N'Sector 32 Jodupur Road New Delhi', CAST(N'2023-07-27' AS Date), N'cle512@gmail.com')
INSERT [dbo].[clerk_details] ([Clerk_Id], [Clerk_Name], [Password], [age], [Gender], [Address], [Date_of_Joining], [Email_Id]) VALUES (N'CLE1901227888', N'J K Rowlin', N'Cle0060@', 20, N'Female', N'Nagasandra Avaion Town New Delhi', CAST(N'2023-07-14' AS Date), N'jkrowlin@gmail.com')
GO
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC1901227008', N'Dr. Amisha Kirti', 25, 3, N'MBBS MD', N'Sector 12 Main Street New Delhi', 8709025091, N'doc008@gmail.com')
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC190122709', N'Dr. J K Rowlin', 25, 6, N'BDS', N'Sector 12 Main Street New Delhi', 9910123487, N'doc709@gmail.com')
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC190122714', N'Dr. Aakansha Singh', 27, 3, N'BDS', N'WhiteFeild Area New Delhi', 8102201545, N'doc714@gmail.com')
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC190122740', N'Dr. Suman Kar', 35, 10, N'MBBS DM', N'Sector 33 Oak St Village New Delhi', 8210529175, N'doc540@gmail.com')
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC1901227545', N'Dr. Swati Kumari', 27, 5, N'MBBS MS', N'Sector 45 Elem St Town New Delhi', 8102671773, N'doc545@gmail.com')
INSERT [dbo].[doctor_details] ([doctor_Id], [doctor_Name], [age], [Experience], [Qualification], [Address], [Contact_No], [Email_Id]) VALUES (N'DOC1901227555', N'Dr. Sanjeev Awasthi', 45, 15, N'MBBS MS', N'Williom Son Town New Delhi', 72831009877, N'sanjeevawasthi@gmail.com')
GO
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P001', CAST(N'2022-05-31T00:00:00.000' AS DateTime), N'Dr. Amisha Kirti', N'Fever and headache', N'Take plenty of rest', N'Good', N'PA001')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P0010', CAST(N'2022-09-01T00:00:00.000' AS DateTime), N'Dr. Swati Kumari', N'Covid_19', N'Follow the contamination Period', N'Okay', N'PA001')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P0011', CAST(N'2023-10-13T00:00:00.000' AS DateTime), N'Dr. Amisha Kirti', N'Gastric Acidity', N'Exercise Daily', N'Outstanding', N'PA002')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P0012', CAST(N'2023-12-28T00:00:00.000' AS DateTime), N'Dr. Sanjeev Awasthi', N'Disorder And Cyst', N'Take Rest And Eat Healthy Food', N'Outstanding', N'PA004')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P0013', CAST(N'2023-07-13T00:00:00.000' AS DateTime), N'Dr. Aakansha Singh', N'Cough and Headache', N'Contamination Period', N'Excellent', N'PA003')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P0015', CAST(N'2023-07-14T00:00:00.000' AS DateTime), N'string', N'string', N'string', N'string', N'PA002')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P002', CAST(N'2022-07-15T00:00:00.000' AS DateTime), N'Dr. Swati Kumari', N'Infection and fever', N'Finish the full course', N'Excellent', N'PA002')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P003', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'Dr. Aakansha Singh', N'Cold and cough', N'Take prescribed medications', N'Satisfactory', N'PA003')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P004', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'Dr. Suman Kar', N'Stomach pain', N'Take rest', N'Nice', N'PA004')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P005', CAST(N'2022-09-30T00:00:00.000' AS DateTime), N'Dr. Amisha Kirti', N'Allergies', N'Take prescribed medicines', N'Excellent', N'PA005')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P006', CAST(N'2022-05-31T00:00:00.000' AS DateTime), N'Dr. Suman Kar', N'Fever and Cough', N'Take plenty of rest', N'Good', N'PA003')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P007', CAST(N'2022-10-30T00:00:00.000' AS DateTime), N'Dr Swati Kumari', N'Headache', N'Take rest', N'Excellent', N'PA004')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P008', CAST(N'2022-10-30T00:00:00.000' AS DateTime), N'Dr Swati Kumari', N'Headache And Migrane', N'Take rest', N'Excellent', N'PA004')
INSERT [dbo].[feedback_details] ([prescription_id], [consultation_date], [doctor_name], [problem_description], [additional_notes], [feedback_detailscol], [prescription_details_patient_id]) VALUES (N'P009', CAST(N'2022-08-10T00:00:00.000' AS DateTime), N'Dr. Aakansha Singh', N'Cold and cough', N'Take Prescribed Medicine On time', N'Satisfactory', N'PA002')
GO
INSERT [dbo].[medicine_bill] ([Cc_Number], [patient_id], [doctor_name], [consul_date], [prescription_id], [doctor_Id], [date_of_prescription], [medicine_id], [Patient_No]) VALUES (123456789, N'PA001', N'Dr. Amisha Kirti', CAST(N'2022-05-31T09:00:00.000' AS DateTime), N'P001', N'DOC1901227008', CAST(N'2022-06-01' AS Date), N'M001', N'PAT20001')
INSERT [dbo].[medicine_bill] ([Cc_Number], [patient_id], [doctor_name], [consul_date], [prescription_id], [doctor_Id], [date_of_prescription], [medicine_id], [Patient_No]) VALUES (234567890, N'PA002', N'Dr. Swati Kumari', CAST(N'2022-07-15T14:30:00.000' AS DateTime), N'P002', N'DOC1901227545', CAST(N'2022-07-01' AS Date), N'M005', N'PAT20004')
INSERT [dbo].[medicine_bill] ([Cc_Number], [patient_id], [doctor_name], [consul_date], [prescription_id], [doctor_Id], [date_of_prescription], [medicine_id], [Patient_No]) VALUES (345678901, N'PA003', N'Dr. Aakansha Singh', CAST(N'2022-08-10T10:30:00.000' AS DateTime), N'P003', N'DOC190122714', CAST(N'2022-08-05' AS Date), N'M003', N'PAT20005')
INSERT [dbo].[medicine_bill] ([Cc_Number], [patient_id], [doctor_name], [consul_date], [prescription_id], [doctor_Id], [date_of_prescription], [medicine_id], [Patient_No]) VALUES (456789012, N'PA004', N'Dr. Suman Kar', CAST(N'2022-08-10T10:30:00.000' AS DateTime), N'P004', N'DOC190122740', CAST(N'2022-09-05' AS Date), N'M005', N'PAT20006')
INSERT [dbo].[medicine_bill] ([Cc_Number], [patient_id], [doctor_name], [consul_date], [prescription_id], [doctor_Id], [date_of_prescription], [medicine_id], [Patient_No]) VALUES (567890123, N'PA005', N'Dr. Amisha Kirti', CAST(N'2022-09-30T10:30:00.000' AS DateTime), N'P005', N'DOC1901227008', CAST(N'2022-10-20' AS Date), N'M001', N'PAT20003')
GO
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M001', N'Paracetamol', N'Johnson Pharmaceuticals', N'Tablet', N'Dry', 24, 2, CAST(N'2022-06-15' AS Date), CAST(N'2024-06-15' AS Date), N'DOC190122740')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M002', N'Amoxicillin', N'Pfizer', N'Capsule', N'Cool', 6, 20, CAST(N'2022-07-01' AS Date), CAST(N'2023-07-01' AS Date), N'DOC190122714')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M003', N'Omeprazole', N'AstraZeneca', N'Tablet', N'Dry', 14, 15, CAST(N'2022-05-20' AS Date), CAST(N'2023-05-20' AS Date), N'DOC1901227545')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M004', N'Ibuprofen', N'Novartis', N'Tablet', N'Dry', 10, 75, CAST(N'2022-09-10' AS Date), CAST(N'2023-09-10' AS Date), N'DOC1901227008')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M005', N'Lisinopril', N'Merck', N'Tablet', N'Cool', 12, 50, CAST(N'2022-08-05' AS Date), CAST(N'2023-08-05' AS Date), N'DOC1901227008')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M006', N'Boredex', N'Johnson Pharmaceuticals', N'Tablet', N'Dry', 24, 4, CAST(N'2022-06-15' AS Date), CAST(N'2022-06-15' AS Date), N'DOC190122740')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M007', N'Benadryl', N'Pifzer', N'Tablet', N'Dry&Warm', 1, 208, CAST(N'2022-06-15' AS Date), CAST(N'2022-06-15' AS Date), N'DOC1901227545')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M008', N'Betadin', N'Unichef', N'Loation', N'Cool', 1, 570, CAST(N'2023-10-24' AS Date), CAST(N'2026-10-15' AS Date), N'DOC1901227545')
INSERT [dbo].[medicine_details] ([medicine_id], [medicine_name], [company_name], [medicine_type], [storage_type], [quantity], [price_per_unit], [manufacture_date], [expiry_date], [doctor_Id]) VALUES (N'M009', N'Azethromycin', N'Pfizer', N'Capsule', N'Cool', 6, 20, CAST(N'2022-07-01' AS Date), CAST(N'2022-07-01' AS Date), N'DOC190122714')
GO
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20001', N'Amisha Srivastava', 27, N'Sector 18 Ata Market Noida UP', N'Female', 9304493348, N'amisha@gmail.com')
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20002', N'Manisha Kumari', 22, N'Old Town Village Gaziabad UP', N'Female', 9693606701, N'manishakri@gmail.com')
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20003', N'Komal', 30, N'Sector 18 Ghandhinagar Road Lucknow', N'Female', 9587413540, N'komalsai@gmail.com')
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20004', N'Harshita Hani', 33, N'Sector 12 Chandni Chowk Road New Delhi', N'Female', 6206856767, N'harshitahani@gmail.com')
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20005', N'Harshit Kumar', 50, N'Sector 36 China Town New Delhi', N'Male', 8789699031, N'harshitkumar@gmail.com')
INSERT [dbo].[patient_details] ([Patient_No], [Patient_Name], [age], [Address], [Gender], [Contact_No], [Email_Id]) VALUES (N'PAT20006', N'S M Hassan Rizzvi', 42, N'Sector 38 Indra Nagar New Delhi', N'Male', 95521145672, N'smhassanveil@gmail.com')
GO
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P001', CAST(N'2022-06-01' AS Date), N'DOC1901227545', N'PAT20001', N'M001', N'Fever and headache', N'Paracetamol And Monteck LC', N'Dolo', 2, 1, N'3 days', N'Take after food', CAST(N'2022-06-04T10:00:00.000' AS DateTime), N'C003', N'PA001', 123456789)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P002', CAST(N'2022-07-15' AS Date), N'DOC1901227545', N'PAT20004', N'M005', N'Infection and fever', N'Amoxicillin and Lisinopril', N'NorFlox TZ', 10, 3, N'7 days', N'Finish the full course', CAST(N'2022-07-22T14:30:00.000' AS DateTime), N'C002', N'PA002', 234567890)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P003', CAST(N'2022-08-10' AS Date), N'DOC190122714', N'PAT20005', N'M003', N'Cold and cough', N'Paracetamol And Montek LC', N'Benadryl', 3, 3, N'5 days', N'Take plenty of fluids', CAST(N'2022-08-15T09:30:00.000' AS DateTime), N'C003', N'PA003', 345678901)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P004', CAST(N'2022-09-05' AS Date), N'DOC190122740', N'PAT20006', N'M004', N'Stomach pain', N'Omeprazole', NULL, 8, 4, N'7 days', N'Take before meals', CAST(N'2022-09-12T11:00:00.000' AS DateTime), N'C004', N'PA004', 456789012)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P005', CAST(N'2022-10-20' AS Date), N'DOC1901227008', N'PAT20003', N'M002', N'Allergies', N'Amoxicillin', N'Telma AM', 25, 4, N'10 days', N'Avoid allergens', CAST(N'2022-10-30T16:00:00.000' AS DateTime), N'C005', N'PA005', 567890123)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P001', CAST(N'2022-06-01' AS Date), N'DOC1901227545', N'PAT20001', N'M001', N'Fever and headache', N'Paracetamol And Monteck LC', N'Dolo', 2, 1, N'3 days', N'Take after food', CAST(N'2022-06-04T10:00:00.000' AS DateTime), N'C001', N'PA006', 123456789)
INSERT [dbo].[prescription_details] ([prescription_id], [prescription_date], [doctor_id], [patient_No], [medicine_id], [problem_description], [prescribed_medicine_name], [alternative_medicine_name], [quantity_to_purchase], [dosage], [duration], [add_note], [next_consaltation_date], [consaltation_id], [patient_id], [medicine_bill_cc_number]) VALUES (N'P003', CAST(N'2022-06-01' AS Date), N'DOC1901227555', N'PAT20001', N'M003', N'Fever and headache', N'Paracetamol And Monteck LC', N'Dolo', 2, 1, N'3 days', N'Take after food', CAST(N'2022-06-04T10:00:00.000' AS DateTime), N'C004', N'PA007', 123456789)
GO
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'CLE1901227504', N'Clerk_504', N'Clerk', N'CLE0010@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'CLE1901227512', N'Clerk_512', N'Clerk', N'CLE0020@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'CLE1901227472', N'Clerk_472', N'Clerk', N'CLE0030@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'CLE1901227471', N'Clerk_471', N'Clerk', N'CLE0040@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'DOC1901227008', N'Doc_008', N'Doctor', N'Doc0010@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'DOC1901227545', N'Doc_545', N'Doctor', N'Doc0020@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'DOC190122740', N'Doc_540', N'Doctor', N'Doc0030@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'DOC190122714', N'Doc_714', N'Doctor', N'Doc0040@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20001', N'Pat_001', N'Patient', N'Pat0010@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20002', N'Pat_002', N'Patient', N'Pat0020@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20003', N'Pat_003', N'Patient', N'Pat0030@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20004', N'Pat_004', N'Patient', N'Pat0040@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20005', N'Pat_005', N'Patient', N'Pat0050@')
INSERT [dbo].[user_details] ([user_id], [user_name], [user_type], [user_psw]) VALUES (N'PAT20006', N'Pat_006', N'Patient', N'Pat0060@')
GO
ALTER TABLE [dbo].[feedback_details]  WITH CHECK ADD FOREIGN KEY([prescription_details_patient_id])
REFERENCES [dbo].[prescription_details] ([patient_id])
GO
ALTER TABLE [dbo].[medicine_bill]  WITH CHECK ADD FOREIGN KEY([doctor_Id])
REFERENCES [dbo].[doctor_details] ([doctor_Id])
GO
ALTER TABLE [dbo].[medicine_bill]  WITH CHECK ADD FOREIGN KEY([medicine_id])
REFERENCES [dbo].[medicine_details] ([medicine_id])
GO
ALTER TABLE [dbo].[medicine_bill]  WITH CHECK ADD FOREIGN KEY([Patient_No])
REFERENCES [dbo].[patient_details] ([Patient_No])
GO
ALTER TABLE [dbo].[medicine_bill]  WITH CHECK ADD FOREIGN KEY([prescription_id])
REFERENCES [dbo].[feedback_details] ([prescription_id])
GO
ALTER TABLE [dbo].[medicine_details]  WITH CHECK ADD FOREIGN KEY([doctor_Id])
REFERENCES [dbo].[doctor_details] ([doctor_Id])
GO
ALTER TABLE [dbo].[prescription_details]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctor_details] ([doctor_Id])
GO
ALTER TABLE [dbo].[prescription_details]  WITH CHECK ADD FOREIGN KEY([medicine_id])
REFERENCES [dbo].[medicine_details] ([medicine_id])
GO
ALTER TABLE [dbo].[prescription_details]  WITH CHECK ADD FOREIGN KEY([patient_No])
REFERENCES [dbo].[patient_details] ([Patient_No])
GO
ALTER TABLE [dbo].[prescription_details]  WITH CHECK ADD  CONSTRAINT [medicine_bill_cc_number] FOREIGN KEY([medicine_bill_cc_number])
REFERENCES [dbo].[medicine_bill] ([Cc_Number])
GO
ALTER TABLE [dbo].[prescription_details] CHECK CONSTRAINT [medicine_bill_cc_number]
GO
ALTER TABLE [dbo].[prescription_details]  WITH CHECK ADD  CONSTRAINT [prescription_id] FOREIGN KEY([prescription_id])
REFERENCES [dbo].[feedback_details] ([prescription_id])
GO
ALTER TABLE [dbo].[prescription_details] CHECK CONSTRAINT [prescription_id]
GO
/****** Object:  StoredProcedure [dbo].[AddPatient]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPatient]
@Patient_No VARCHAR(20),
@Patient_Name VARCHAR(20),
@age INTEGER,
@Address VARCHAR(100),
@Gender  VARCHAR(20),
@Contact_No BIGINT,
@Email_Id VARCHAR(100)
AS
BEGIN
 INSERT INTO patient_details (Patient_No, Patient_Name, age, Address, Gender, Contact_No, Email_Id) VALUES (@Patient_No, @Patient_Name, @age, @Address, @Gender, @Contact_No, @Email_Id);
END;
GO
/****** Object:  StoredProcedure [dbo].[GetDetailsDoctor]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDetailsDoctor]
AS
BEGIN
Select * from doctor_details;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetDetailsMedicine]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDetailsMedicine]
AS
BEGIN
Select * from medicine_details
END;
GO
/****** Object:  StoredProcedure [dbo].[GetDetailsMedicinebyid]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDetailsMedicinebyid]
@medicine_id VARCHAR(20)
AS
BEGIN
SELECT * FROM medicine_details WHERE medicine_id = @medicine_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetDetailsPatient]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDetailsPatient]
AS
BEGIN
SELECT * FROM patient_details;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetMedicineBills]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMedicineBills]
AS
BEGIN
Select * from medicine_bill;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetMedicineByCcNumber]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMedicineByCcNumber]
@ccNumber int
AS
BEGIN
SELECT * FROM medicine_bill WHERE Cc_Number = @ccNumber;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPrescriptionDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPrescriptionDetails]
AS
BEGIN
Select * from prescription_details;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPrescriptionDetailsbypatientid]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPrescriptionDetailsbypatientid]
@patient_id VARCHAR(20)
AS
BEGIN
SELECT * FROM prescription_details WHERE patient_id = @patient_id;
END
GO
/****** Object:  StoredProcedure [dbo].[GetPrescriptionDetailsid]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPrescriptionDetailsid]
@patient_id VARCHAR(20)
AS
BEGIN
select * from prescription_details where patient_id = @patient_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPrescriptionDetailspatients]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPrescriptionDetailspatients]
@patient_id VARCHAR(20)
AS
BEGIN
SELECT * FROM prescription_details WHERE patient_id = @patient_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetUserRole]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUserRole]
@user_id VARCHAR(20)
AS
BEGIN
SELECT user_type FROM user_details WHERE user_id = @user_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SaveClerkDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveClerkDetails]
@Clerk_Id VARCHAR(20),
@Clerk_Name VARCHAR(20),
@Password VARCHAR(50),
@age INTEGER,
@Gender VARCHAR(10),
@Address VARCHAR(100),
@Date_of_Joining DATE,
@Email_Id VARCHAR(20)
AS
BEGIN
INSERT INTO clerk_details (Clerk_Id , Clerk_Name, Password, age, Gender, Address, Date_of_Joining ,Email_Id) VALUES (@Clerk_Id, @Clerk_Name, @Password, @age, @Gender, @Address ,@Date_of_Joining, @Email_Id);
END;
GO
/****** Object:  StoredProcedure [dbo].[SaveDoctorDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveDoctorDetails]
@doctor_Id VARCHAR(20),
@doctor_Name VARCHAR(20),
@age INTEGER,
@Experience INTEGER,
@Qualification VARCHAR(100),
@Address VARCHAR(100),
@Contact_No  BIGINT,
@Email_Id VARCHAR(100)
AS
BEGIN
INSERT INTO doctor_details (doctor_Id, doctor_Name, age, Experience, Qualification, Address, Contact_No ,Email_Id) VALUES (@doctor_Id, @doctor_Name, @age, @Experience, @Qualification, @Address, @Contact_No ,@Email_Id);
END;
GO
/****** Object:  StoredProcedure [dbo].[SaveFeedbackDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveFeedbackDetails]
@prescription_id VARCHAR(20),
@consultation_date VARCHAR(200),
@doctor_name VARCHAR(20),
@problem_description VARCHAR(20),
@additional_notes VARCHAR(500),
@feedback_detailscol VARCHAR(45),
@prescription_details_patient_id VARCHAR(20)
AS
BEGIN
INSERT INTO feedback_details (prescription_id, consultation_date, doctor_name, problem_description, additional_notes, feedback_detailscol, prescription_details_patient_id)
VALUES (@prescription_id, @consultation_date, @doctor_name, @problem_description, @additional_notes, @feedback_detailscol, @prescription_details_patient_id)
END;
GO
/****** Object:  StoredProcedure [dbo].[SaveMedicineDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveMedicineDetails]
@medicine_id VARCHAR(20),
@medicine_name VARCHAR(20),
@company_name VARCHAR(300),
@medicine_type VARCHAR(50),
@storage_type VARCHAR(10),
@quantity INTEGER,
@price_per_unit INTEGER, 
@manufacture_date DATE, 
@expiry_date DATE, 
@doctor_id VARCHAR(20)
AS
BEGIN
INSERT INTO medicine_details (medicine_id, medicine_name, company_name, medicine_type, storage_type, quantity, price_per_unit, manufacture_date, expiry_date, doctor_id) VALUES (@medicine_id, @medicine_name, @company_name, @medicine_type, @storage_type, @quantity, @price_per_unit, @manufacture_date, @expiry_date, @doctor_id);
END;
GO
/****** Object:  StoredProcedure [dbo].[SavePrescriptionDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SavePrescriptionDetails]
@prescription_id VARCHAR(20),
@prescription_date DATE,
@doctor_id VARCHAR(20),
@patient_No VARCHAR(20),
@medicine_id VARCHAR(20),
@problem_description VARCHAR(700),
@prescribed_medicine_name VARCHAR(300),
@alternative_medicine_name VARCHAR(20),
@quantity_to_purchase INTEGER,
@dosage INTEGER,
@duration VARCHAR(20),
@add_note VARCHAR(100),
@next_consaltation_date DATETIME,
@consaltation_id VARCHAR(200),
@patient_id VARCHAR(20),
@medicine_bill_cc_number INTEGER
AS
BEGIN
INSERT INTO prescription_details (prescription_id, prescription_date, doctor_id, patient_No, medicine_id ,problem_description, prescribed_medicine_name, alternative_medicine_name, quantity_to_purchase, dosage, duration, add_note, next_consaltation_date, consaltation_id, patient_id, medicine_bill_cc_number) 
VALUES (@prescription_id, @prescription_date, @doctor_id, @patient_No, @medicine_id, @problem_description, @prescribed_medicine_name, @alternative_medicine_name, @quantity_to_purchase, @dosage, @duration, @add_note, @next_consaltation_date, @consaltation_id, @patient_id, @medicine_bill_cc_number);
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateClerkDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateClerkDetails]
@Clerk_Id VARCHAR(20),
@Clerk_Name VARCHAR(20),
@Password VARCHAR(50),
@age INTEGER,
@Gender VARCHAR(10),
@Address VARCHAR(100),
@Date_of_Joining DATE,
@Email_Id VARCHAR(20)
AS
BEGIN
UPDATE clerk_details SET Clerk_Name = @Clerk_Name, Password = @Password, age = @age, Gender = @Gender, Address = @Address , Email_Id = @Email_Id WHERE Clerk_Id = @Clerk_Id ;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateDoctorDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateDoctorDetails]
@doctor_Id VARCHAR(20),
@doctor_Name VARCHAR(20),
@age INTEGER,
@Experience INTEGER,
@Qualification VARCHAR(100),
@Address VARCHAR(100),
@Contact_No BIGINT,
@Email_Id VARCHAR(100)
AS
BEGIN
UPDATE doctor_details SET doctor_Name = @doctor_Name, age = @age, Experience = @Experience, Qualification = @Qualification, Address = @Address, Contact_No = @Contact_No ,Email_Id = @Email_Id WHERE doctor_Id = @doctor_Id;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateFeedbackDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateFeedbackDetails]
@prescription_id VARCHAR(20),
@consultation_date VARCHAR(200),
@doctor_name VARCHAR(20),
@problem_description  VARCHAR(20),
@additional_notes VARCHAR(500),
@feedback_detailscol VARCHAR(45),
@prescription_details_patient_id  VARCHAR(20)
AS
BEGIN
UPDATE feedback_details SET consultation_date=@consultation_date, doctor_name=@doctor_name, problem_description=@problem_description, additional_notes=@additional_notes, feedback_detailscol=@feedback_detailscol, prescription_details_patient_id=@prescription_details_patient_id WHERE prescription_id = @prescription_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateMedicineDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateMedicineDetails]
@medicine_id VARCHAR(20),
@medicine_name VARCHAR(20),
@company_name VARCHAR(300),
@medicine_type VARCHAR(50),
@storage_type VARCHAR(10),
@quantity INTEGER,
@price_per_unit INTEGER, 
@manufacture_date DATE, 
@expiry_date DATE, 
@doctor_id VARCHAR(20)
AS
BEGIN
UPDATE medicine_details SET medicine_name = @medicine_name, company_name = @company_name, medicine_type = @medicine_type, storage_type = @storage_type, quantity = @quantity, price_per_unit = @price_per_unit, manufacture_date = @manufacture_date, expiry_date = @expiry_date, doctor_id = @doctor_id WHERE medicine_id = @medicine_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePatient]
@Patient_No VARCHAR(20),
@Patient_Name VARCHAR(20),
@age INTEGER,
@Address VARCHAR(100),
@Gender  VARCHAR(20),
@Contact_No BIGINT,
@Email_Id VARCHAR(100)
AS
BEGIN
UPDATE patient_details SET Patient_Name = @Patient_Name, age = @age, Address = @Address, Gender = @Gender, Contact_No = @Contact_No, Email_Id = @Email_Id WHERE Patient_No = @Patient_No;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePrescriptionDetails]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePrescriptionDetails]
@prescription_id VARCHAR(20),
@prescription_date DATE,
@doctor_id VARCHAR(20),
@patient_No VARCHAR(20),
@medicine_id VARCHAR(20),
@problem_description VARCHAR(700),
@prescribed_medicine_name VARCHAR(300),
@alternative_medicine_name VARCHAR(20),
@quantity_to_purchase INTEGER,
@dosage INTEGER,
@duration VARCHAR(20),
@add_note VARCHAR(100),
@next_consaltation_date DATETIME,
@consaltation_id VARCHAR(200),
@patient_id VARCHAR(20),
@medicine_bill_cc_number INTEGER
AS
BEGIN
UPDATE prescription_details SET @prescription_id = @prescription_id , prescription_date = @prescription_date, doctor_id = @doctor_id, patient_No = @patient_No, medicine_id = @medicine_id , problem_description = @problem_description, prescribed_medicine_name = @prescribed_medicine_name, alternative_medicine_name = @alternative_medicine_name, quantity_to_purchase = @quantity_to_purchase, dosage = @dosage, duration = @duration, add_note = @add_note, next_consaltation_date = @next_consaltation_date, consaltation_id = @consaltation_id, medicine_bill_cc_number = @medicine_bill_cc_number WHERE patient_id = @patient_id;
END
GO
/****** Object:  StoredProcedure [dbo].[VerifyUser]    Script Date: 17/07/2023 11:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerifyUser]
@user_id varchar(20),
@user_psw varchar(50)
AS
BEGIN
SELECT COUNT(*) FROM user_details WHERE user_id = @user_id AND user_psw = @user_psw;
END;
GO
