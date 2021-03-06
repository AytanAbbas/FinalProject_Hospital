USE [HospitalDB]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'11ec9e06-9598-4c2e-b985-e91b77bdeed8', N'SuperAdmin', N'SuperAdmin', N'2a9176b3-02a3-4fef-8424-d72c18656809')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'26460f72-d45d-4978-a444-83fdb728a8a6', N'Admin', N'Admin', N'af29d7fb-c903-4793-977b-83ff10f26d7f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a5385a27-bf7e-4a4c-a003-5edd4f03ec6a', N'Moderator', N'MODERATOR', N'aa4d662c-973a-457f-a39a-dc8b65ae11b2')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [CreatedDate], [Discriminator], [Image], [Name], [Surname]) VALUES (N'1a4ed4c8-a142-4631-9bab-bedf1452ee6c', N'inci@gmail.com', N'INCI@GMAIL.COM', N'inci@gmail.com', N'INCI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJsHSdLv4poCmWQsVhoV6k6guZN67usKHaNacyli6MDUFUdYN75g3AxwgyFWyQWvPw==', N'3NH6A67KO5KQ3BLGLQNNQDYAS34DTQKY', N'6122fb7f-704e-40f3-9740-e46e55f6c0a9', NULL, 0, 0, NULL, 1, 0, CAST(N'2022-02-27T02:34:15.9708290' AS DateTime2), N'CustomUser', NULL, N'Inci', N'Seyfullayeva')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [CreatedDate], [Discriminator], [Image], [Name], [Surname]) VALUES (N'd8b33324-1e5c-4be3-b3bf-8c03d7aa727e', N'aytan@gmail.com', N'AYTAN@GMAIL.COM', N'aytan@gmail.com', N'AYTAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEByp/BdfJGnLY6vD+nT/0g43Pq3qi4q3BlT7XGBEUPK6YMyHlfG5h+y170mkvF7clA==', N'6MUXUBJ5ODU6LRPB5452BC3NFLYWLCM4', N'f19c3fe6-3e07-4ae2-a76e-eb08e3e325c0', NULL, 0, 0, NULL, 1, 0, CAST(N'2022-02-27T02:32:18.9850118' AS DateTime2), N'CustomUser', NULL, N'Aytan', N'Abbas')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd8b33324-1e5c-4be3-b3bf-8c03d7aa727e', N'11ec9e06-9598-4c2e-b985-e91b77bdeed8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a4ed4c8-a142-4631-9bab-bedf1452ee6c', N'26460f72-d45d-4978-a444-83fdb728a8a6')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Cardiology')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Orthopedics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Pharmacy')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Anestheslology')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Pediatric')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Researches] ON 

INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (17, N'86c7aa9c-91ca-4fa0-8450-10a4f97b57c3-09March2022-01.jpg', N'b9c6d08a-6b20-4cf4-804d-6227318188ba-09March2022-services-03.jpg', N' Fitness Guidance to Patient', N'John Michael', CAST(N'2019-04-05T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 1)
INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (21, N'65b52e5f-1d3e-4959-8941-9fb8e44b47c9-09March2022-02.jpg', N'147a327b-0b70-4135-a517-a7de806f172e-09March2022-services-03.jpg', N' Diagnostic Imagine', N'John Michael', CAST(N'2020-08-06T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 2)
INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (22, N'80ec6a68-8b0b-42e8-bc7f-6cf29434083f-09March2022-03.jpg', N'443ccae2-e322-4ba7-a7df-fbe55bfe115f-09March2022-services-03.jpg', N' Orthodontics Surgery', N'John Michael', CAST(N'2014-12-25T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 3)
INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (23, N'0f4e9c12-ff86-4d47-9ab9-ba2bb4b48741-09March2022-04.jpg', N'116dfb6d-0a29-41c8-b2e5-3cdcdc2a4522-09March2022-services-03.jpg', N'Rehabilitation Center', N'John Michael', CAST(N'2019-06-06T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina Category', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 4)
INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (24, N'f2d4da5e-6f76-4bfa-a310-4ce3a183a67c-09March2022-05.jpg', N'2513e9d1-9fcb-4a57-a86a-e82f87702f7a-09March2022-services-03.jpg', N'Blood Pressure Checkup', N'John Michael', CAST(N'2021-09-27T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina ', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 5)
INSERT [dbo].[Researches] ([Id], [MainImage], [DetailImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [CatId]) VALUES (25, N'33caca89-62f4-4de6-b757-67784c7cac19-09March2022-06.jpg', N'501c5ffe-f938-4a0c-8ded-42db234c5da2-09March2022-services-03.jpg', N'Dentures / Partial Dentures', N'John Michael', CAST(N'2017-02-22T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', 1)
SET IDENTITY_INSERT [dbo].[Researches] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (1, N'Sample Preparation', N'83%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (2, N'Environmental Testing', N'96%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (3, N'Advanced Microscopy', N'
90%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (4, N'Environmental Testing', N'
96%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (5, N'Advanced Microscopy
', N'90%')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[Universities] ON 

INSERT [dbo].[Universities] ([Id], [Medical], [Residency]) VALUES (1, N' University of Sydney, Australia', N'Stereotactic Radiosurgery, Glioma')
INSERT [dbo].[Universities] ([Id], [Medical], [Residency]) VALUES (2, N' University of Sydney, Australia', N'Stereotactic Radiosurgery, Glioma')
INSERT [dbo].[Universities] ([Id], [Medical], [Residency]) VALUES (3, N' University of Sydney, Australia', N'Stereotactic Radiosurgery, Glioma')
INSERT [dbo].[Universities] ([Id], [Medical], [Residency]) VALUES (4, N' University of Sydney, Australia', N'Stereotactic Radiosurgery, Glioma')
INSERT [dbo].[Universities] ([Id], [Medical], [Residency]) VALUES (5, N' University of Sydney, Australia', N'Stereotactic Radiosurgery, Glioma')
SET IDENTITY_INSERT [dbo].[Universities] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (3, N'e3388465-5162-4d61-a6d6-03441645cdc1-20220309005329-team-img01.jpg', N'Duck Peter', N'CEO At Lab', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'12+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1, N'33', N'duckpeter@gmailcom')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (5, N'1e4b2428-0325-42a1-bc1b-78d4d32af51e-20220309005417-team-img02.jpg', N'Lexa May Cruz', N'Radiologist', N'283-456-72490', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 2, N'17', N'lexamay@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (6, N'ea86016b-5671-48e1-87b6-1cedf65ec9dd-20220309005450-team-img03.jpg', N'Andrew Bon', N'Clinical biochemist', N'725-326-71590', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'14+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 3, N'2', N'andrewbon@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (7, N'6f256c5f-11a1-4177-ae88-82c64ffb9e41-20220309005528-team-img04.jpg', N'John Martin', N'Dentist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N' American Board of Neurological Surgery', N' Stereovctic Radiosurgery, Glioma', 4, N'24', N'johnmartin@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (8, N'0da0cd4b-d98f-48ef-82a6-319071ed65df-20220309005637-team-img05.jpg', N'Thomas Charlie', N'Laboratory assistant', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'10+ Years', N' American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1, N'12', N'thomas@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (9, N'e45ce7f9-be78-4090-9ec8-1171d5f0d1d7-20220309005732-team-img06.jpg', N'Lena Mayer Cruz', N'Psychiatrist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N' American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 2, N'7', N'lenamayer@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (10, N'9083585c-53a9-49fa-a8f0-2838c51bce2b-20220309005802-team-img03.jpg', N'Alex Winston', N'Anesthesiologist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'13+ Years', N'American Board of Neurological Surgery', N' Stereovctic Radiosurgery, Glioma', 3, N'25', N'alexwinston@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (11, N'f63d0341-fa06-4ae4-8dd2-543edf04a1e5-20220309005836-team-img06.jpg', N'Jack Callum', N'Pediatrist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'6+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1, N'35', N'jackcallum@gmail.com')
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId], [CabinNumber], [Email]) VALUES (20, N'2970fb0b-ce3c-4998-b329-ff421aa63240-20220309011529-team-img02.jpg', N'Mika Nyuton', N'Therapist', N'+9875445678', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'4', N' American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1, N'26', N'mikanyuton@gmail.com')
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillToTeams] ON 

INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (46, 3, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (47, 3, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (48, 3, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (49, 3, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (50, 3, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (51, 5, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (52, 5, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (53, 5, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (54, 5, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (55, 5, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (56, 6, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (57, 6, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (58, 6, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (59, 6, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (60, 6, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (61, 7, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (62, 7, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (63, 7, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (64, 7, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (65, 7, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (66, 8, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (67, 8, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (68, 8, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (69, 8, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (70, 8, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (71, 9, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (72, 9, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (73, 9, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (74, 9, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (75, 9, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (76, 10, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (77, 10, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (78, 10, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (79, 10, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (80, 10, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (81, 11, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (82, 11, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (83, 11, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (84, 11, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (85, 11, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (101, 20, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (102, 20, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (103, 20, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (104, 20, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (105, 20, 5)
SET IDENTITY_INSERT [dbo].[SkillToTeams] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkExperiences] ON 

INSERT [dbo].[WorkExperiences] ([Id], [Icon], [Title], [About]) VALUES (2, N'fas fa-user-tag', N'Intensive care', N'Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam.')
INSERT [dbo].[WorkExperiences] ([Id], [Icon], [Title], [About]) VALUES (3, N'fas fa-microscope', N'Biology Research', N'Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam.')
INSERT [dbo].[WorkExperiences] ([Id], [Icon], [Title], [About]) VALUES (4, N'fas fa-vials', N'Catalysis Processes', N'Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam.')
SET IDENTITY_INSERT [dbo].[WorkExperiences] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamExperiences] ON 

INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (5, 3, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (6, 3, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (7, 3, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (8, 5, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (9, 5, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (10, 5, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (11, 6, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (12, 6, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (13, 6, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (14, 7, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (15, 7, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (16, 7, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (17, 8, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (18, 8, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (19, 8, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (20, 9, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (21, 9, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (22, 9, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (23, 10, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (24, 10, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (25, 10, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (26, 11, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (27, 11, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (28, 11, 4)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (33, 20, 2)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (34, 20, 3)
INSERT [dbo].[TeamExperiences] ([Id], [TeamId], [WorkExperienceId]) VALUES (35, 20, 4)
SET IDENTITY_INSERT [dbo].[TeamExperiences] OFF
GO
SET IDENTITY_INSERT [dbo].[ResearchImages] ON 

INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (26, N'562ebe69-119e-447d-a413-6da00320c28f-09March2022-01.jpg', 17)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (27, N'368819e2-026e-49bf-88e2-90056345cb9f-09March2022-02.jpg', 17)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (28, N'09919cc4-12f3-4b6b-87ce-3c7320b1912c-09March2022-03.jpg', 17)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (29, N'4df2ebcb-8dbe-4ccf-883b-ec00a0143714-09March2022-04.jpg', 17)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (30, N'e0b8b289-77e9-4fe5-9934-38502361ceba-09March2022-05.jpg', 21)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (31, N'c32c00ef-1453-4cea-9afd-c24a25dab37b-09March2022-06.jpg', 21)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (32, N'4ae41bf6-d111-4855-980a-c4854fe66137-09March2022-01.jpg', 21)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (33, N'0e81cb6a-ad86-4915-a24c-1b8cd696eff9-09March2022-02.jpg', 21)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (34, N'34003370-315c-455c-95c4-3799d7d2c08a-09March2022-03.jpg', 22)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (35, N'44408143-b611-4b37-bd48-48f2e3fd5591-09March2022-04.jpg', 22)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (36, N'e2784f79-4757-4448-b50b-1f6814236f92-09March2022-05.jpg', 22)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (37, N'c4b2bbca-e24e-4c97-9c82-c270b71c99fb-09March2022-06.jpg', 22)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (38, N'06de1874-f721-4404-b754-3f80f7881be4-09March2022-01.jpg', 23)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (39, N'6d4f44ed-abc0-45d8-813f-f9f12d12be06-09March2022-02.jpg', 23)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (40, N'c752e0bf-c302-4b9c-9122-9639b1dc366c-09March2022-03.jpg', 23)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (41, N'5b57a2d1-c943-4056-bae7-9e19be75e3ca-09March2022-04.jpg', 23)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (42, N'806464a0-b084-42ce-b865-b57adece8a61-09March2022-05.jpg', 24)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (43, N'fa197d6b-4681-4017-a95e-b920dac800f9-09March2022-06.jpg', 24)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (44, N'8a4fa6a8-d1db-4c43-98e6-6d016e1dee9c-09March2022-01.jpg', 24)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (45, N'f888053c-0b21-474e-8a4e-77c91dbc98cf-09March2022-03.jpg', 24)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (46, N'c6ead00c-c267-474e-bbfa-bfdc05f68d3a-09March2022-06.jpg', 25)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (47, N'a6570a74-c16b-4b60-884c-76f1bf871bcf-09March2022-04.jpg', 25)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (48, N'88a74830-84a6-42ab-ae98-c170a55fe011-09March2022-05.jpg', 25)
INSERT [dbo].[ResearchImages] ([Id], [Image], [ResearchId]) VALUES (49, N'9ce4caa2-4bb3-444f-b42e-b2476e34372d-09March2022-02.jpg', 25)
SET IDENTITY_INSERT [dbo].[ResearchImages] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamSocials] ON 

INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (1, N'facebook', N'fa fa-facebook', N'facebook.com/bilgeyts35', 3)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (2, N'twitter', N'fa fa-twitter', NULL, 3)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (3, N'instagram', N'fa fa-instagram', NULL, 3)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (4, N'facebook', N'fa fa-facebook', NULL, 5)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (5, N'twitter', N'fa fa-twitter', NULL, 5)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (6, N'instagram', N'fa fa-instagram', NULL, 5)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (7, N'facebook', N'fa fa-facebook', NULL, 6)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (8, N'twitter', N'fa fa-twitter', NULL, 6)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (9, N'instagram', N'fa fa-instagram', NULL, 6)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (10, N'facebook', N'fa fa-facebook', NULL, 7)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (11, N'twitter', N'fa fa-twitter', NULL, 7)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (12, N'instagram', N'fa fa-instagram', NULL, 7)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (13, N'facebook', N'fa fa-facebook', NULL, 8)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (14, N'twitter', N'fa fa-twitter', NULL, 8)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (15, N'instagram', N'fa fa-instagram', NULL, 8)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (16, N'facebook', N'fa fa-facebook', NULL, 9)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (17, N'twitter', N'fa fa-twitter', NULL, 9)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (18, N'instagram', N'fa fa-instagram', NULL, 9)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (19, N'facebook', N'fa fa-facebook', NULL, 10)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (20, N'twitter', N'fa fa-twitter', NULL, 10)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (21, N'instagram', N'fa fa-instagram', NULL, 10)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (22, N'facebook', N'fa fa-facebook', NULL, 11)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (23, N'twitter', N'fa fa-twitter', NULL, 11)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (24, N'instagram', N'fa fa-instagram', NULL, 11)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (29, N'facebook', N'fa fa-facebook', N'facebook.com/bilgeyts35', 20)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (30, N'twitter', N'fa fa-twitter', NULL, 20)
INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (31, N'instagram', N'fa fa-instagram', NULL, 20)
SET IDENTITY_INSERT [dbo].[TeamSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[AboutResearches] ON 

INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (1, N'Central Forensic Science', N'01', N'Forensic science is a discipline that applies scientific analysis to the justice system, help prove the events of crime')
INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (2, N'Clinical & Medical Laboratory', N'02', N'Conducts lab tests ordered by doctors. Working with laboratory machines as we examine human tissue samples & diagnose')
INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (3, N'Analytical & Quality Laboratory', N'03', N'The Various techniques that we are used to identifying the chemical makeup and characteristics of a particular samples')
SET IDENTITY_INSERT [dbo].[AboutResearches] OFF
GO
SET IDENTITY_INSERT [dbo].[Accordions] ON 

INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (8, N'How Should I Beleive About Your Services?', N'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'9760491c-5145-49cd-b590-0582cb1d8fad-11March2022-blog-five-740x504.jpg')
INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (9, N'What Are Laboratory Tests?', N'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'0ae0a71e-924a-4b8d-a529-3c8668108f02-11March2022-blog-five-740x504.jpg')
INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (10, N'Who performs the testing on laboratory specimens?', N'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'867f01c1-beae-406a-bd9d-c3c70e37dff1-11March2022-blog-five-740x504.jpg')
SET IDENTITY_INSERT [dbo].[Accordions] OFF
GO
SET IDENTITY_INSERT [dbo].[Achievements] ON 

INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (1, N'award-one.png')
INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (2, N'award-three.png')
INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (3, N'award-two.png')
INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (4, N'award-two.png')
INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (5, N'award-one.png')
INSERT [dbo].[Achievements] ([Id], [Image]) VALUES (6, N'award-three.png')
SET IDENTITY_INSERT [dbo].[Achievements] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([Id], [Name], [Email], [Phone], [Note], [AppointmentDate], [CreatedDate], [DoctorId], [IsActive], [Gender]) VALUES (68, N'Shahin', N'aytanab@code.edu.az', N'1548268752', N'sjsjjsjsj', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-09T20:24:05.9924587' AS DateTime2), 5, 1, NULL)
INSERT [dbo].[Appointments] ([Id], [Name], [Email], [Phone], [Note], [AppointmentDate], [CreatedDate], [DoctorId], [IsActive], [Gender]) VALUES (69, N'Murad', N'aytanab@code.edu.az', N'15167410', N'xcmx ckx', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-10T21:32:15.8739459' AS DateTime2), 5, 0, NULL)
INSERT [dbo].[Appointments] ([Id], [Name], [Email], [Phone], [Note], [AppointmentDate], [CreatedDate], [DoctorId], [IsActive], [Gender]) VALUES (70, N'samir', N'aytanab@code.edu.az', N'1548268752', N'ganoiwraeg', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-11T01:11:18.3979436' AS DateTime2), 6, 0, NULL)
INSERT [dbo].[Appointments] ([Id], [Name], [Email], [Phone], [Note], [AppointmentDate], [CreatedDate], [DoctorId], [IsActive], [Gender]) VALUES (71, N'samir', N'aytanab@code.edu.az', N'1548268752', N'ganoiwraeg', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-11T23:20:16.6225198' AS DateTime2), 7, 0, NULL)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (1, N'About Us', N'About Us', N'About')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (2, N'Services', N'Services', N'Service')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (3, N'Team ', N'Team', N'Team')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (4, N'Team Details', N'Team Details', N'TeamDetail')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (5, N'Research ', N'Research ', N'Research ')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (6, N'Research Details', N'Research Details', N'ResearchDetail')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (7, N'Contact Us', N'Contact Us', N'ContactUs')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (8, N'Faq', N'Faq', N'Faq')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page]) VALUES (12, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[BgImages] ON 

INSERT [dbo].[BgImages] ([Id], [TestimonialBgImage], [AccordionBgImage], [ServiceBgImage], [FutureBgImage]) VALUES (1, N'row-bgimage-6.jpg', N'row-bgimage-7.jpg', N'row-bgimage-5.png', N'row-bgimage-4.png')
SET IDENTITY_INSERT [dbo].[BgImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Chooses] ON 

INSERT [dbo].[Chooses] ([Id], [BgImage], [About]) VALUES (1, N'8a3a9d02-a2de-4103-94c1-e7b9d0cb3889-11March2022-row-bgimage-8.jpg', N'Our excellent team is ready to be part of your team to work into the different areas of diagnoses. Scientists helping scientists.')
SET IDENTITY_INSERT [dbo].[Chooses] OFF
GO
SET IDENTITY_INSERT [dbo].[ChooseUs] ON 

INSERT [dbo].[ChooseUs] ([Id], [Title], [Icon]) VALUES (1, N'High
Quality Services', N'fas fa-microscope')
INSERT [dbo].[ChooseUs] ([Id], [Title], [Icon]) VALUES (2, N'Fast
Working Process', N'fal fa-dna')
INSERT [dbo].[ChooseUs] ([Id], [Title], [Icon]) VALUES (3, N'Customer Support', N'fal fa-clock')
INSERT [dbo].[ChooseUs] ([Id], [Title], [Icon]) VALUES (4, N'Expert
Labtechician Team', N'fas fa-users')
SET IDENTITY_INSERT [dbo].[ChooseUs] OFF
GO
SET IDENTITY_INSERT [dbo].[FaqMessages] ON 

INSERT [dbo].[FaqMessages] ([Id], [Name], [Email], [Phone], [Message], [CreatedDate]) VALUES (1, N'aytan', N'aytanab@code.edu.az', N'465268962', N'dvniersmbkrjtg', CAST(N'2022-03-06T19:11:53.0359990' AS DateTime2))
SET IDENTITY_INSERT [dbo].[FaqMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[Faqs] ON 

INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (1, N'What Are Laboratory Tests?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (2, N'What Is A Medical Laboratory Or Lab?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (3, N'Who Performs The Testing On Laboratory Specimens?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (4, N'What Can I Do With The Laboratory?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (5, N'Can I Request My Own Laboratory Tests?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
INSERT [dbo].[Faqs] ([Id], [Question], [Answer]) VALUES (6, N'Do I Need An Appointment To Come To The Laboratory?', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry. It has survived not only five centuries, but also the leap into electronic typesetting.')
SET IDENTITY_INSERT [dbo].[Faqs] OFF
GO
SET IDENTITY_INSERT [dbo].[FidSections] ON 

INSERT [dbo].[FidSections] ([Id], [Title], [Icon], [Count]) VALUES (1, N'Awards Winning', N'fas fa-trophy', N'143 ')
INSERT [dbo].[FidSections] ([Id], [Title], [Icon], [Count]) VALUES (2, N'Our Equipments
', N'fas fa-microscope', N'780 ')
INSERT [dbo].[FidSections] ([Id], [Title], [Icon], [Count]) VALUES (3, N'Complete Cases', N'fas fa-search', N'675')
INSERT [dbo].[FidSections] ([Id], [Title], [Icon], [Count]) VALUES (4, N'Industry Expertise', N'fas fa-headset', N'457')
SET IDENTITY_INSERT [dbo].[FidSections] OFF
GO
SET IDENTITY_INSERT [dbo].[Futures] ON 

INSERT [dbo].[Futures] ([Id], [Icon], [Title], [Description]) VALUES (1, N'fas fa-flask', N'The Introductory step', N'It focuses on issues involving family relationships. Like adoption, divorce, child custody etc.')
INSERT [dbo].[Futures] ([Id], [Icon], [Title], [Description]) VALUES (2, N'fal fa-microscope', N'A Safer Health System', N'We are expand funding of the research, training, and the education of safe practices as appropriate')
INSERT [dbo].[Futures] ([Id], [Icon], [Title], [Description]) VALUES (3, N'fal fa-vial', N'Follow NABL regulations', N'Autonomous society providing technical competence of testing, accreditation, medical laboratory.')
SET IDENTITY_INSERT [dbo].[Futures] OFF
GO
SET IDENTITY_INSERT [dbo].[HomeSliders] ON 

INSERT [dbo].[HomeSliders] ([Id], [Image], [Title], [LeftImage], [Link], [RightImage]) VALUES (1, N'hospital-background-images-hd-9.jpg', N'Research & Verify A  Physics Laboratory', N'12.png', N'youtu.be/3yuvPTCof30', N'11.png')
SET IDENTITY_INSERT [dbo].[HomeSliders] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (1, N'client-01.png', N'client-01')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (2, N'client-02.png', N'client-02')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (3, N'client-03.png', N'client-03')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (4, N'client-04.png', N'client-04')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (5, N'client-05.png', N'client-05')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (6, N'client-06.png', N'client-06')
INSERT [dbo].[Partners] ([Id], [Name], [HoverName]) VALUES (7, N'client-03.png', N'client-07')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[ProcessPlans] ON 

INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (1, N'Data Collection', N'fal fa-flask', N'01', N'For the accurate diagnoses, perfect information is must require', N'62b78fdf-aba5-4d27-9063-3f4cec01d59b-11March2022-arrow-1.png')
INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (2, N'Diagnose Process', N'fas fa-microscope', N'02', N'The collection goes to the particular department for the tests', N'6fd51837-ee80-42f6-9d72-07f0556f0722-11March2022-arrow-2.png')
INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (3, N'Access To Reports', N'fal fa-dna', N'03', N'As a result, that arrive one can access their report online or direct ', N'')
SET IDENTITY_INSERT [dbo].[ProcessPlans] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceAbouts] ON 

INSERT [dbo].[ServiceAbouts] ([Id], [Image], [Title], [About]) VALUES (10, N'544d9ed4-b134-48ff-b61f-bb1b4b986a52-09March2022-single-img-ten.png', N'We Employ The Latest Research Technology & Company', N'Paramedical healthcare field attracts to save lives & helping people, being a doctor is not your only choice. We how else you can help patients without being a doctor, here we serving awesome opportunity.well-established experience in epitomizing good laboratory medicine practices & treating the patients with utmost diligence')
SET IDENTITY_INSERT [dbo].[ServiceAbouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Image], [Content], [Phone], [Experience], [Title]) VALUES (1, N'96b21762-899e-422b-b75d-c87fdd925739-09March2022-single-img-four.jpg', N'Our scientists and engineers focus their extreme curiosity on national & health related challenges. Learn more about the Laboratory’s work below segment.', N'+123-456-7890', N'20 Years', N'We Are Laboratory Technologies')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTexnoLabs] ON 

INSERT [dbo].[ServiceTexnoLabs] ([Id], [Image], [Title], [About], [FooterTitle]) VALUES (1, N'16b641ff-532c-40d5-8079-fca487186eab-11March2022-single-img-eight.jpg', N'We Are The Trusted Experts Latest Laboratory Technologies.', N'Our scientists and engineers focus their extreme curiosity on national and global security & health related challenges. Learn more about the Laboratory’s R&D work below segment.', N'High Technology Laboratory solutions')
SET IDENTITY_INSERT [dbo].[ServiceTexnoLabs] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTips] ON 

INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (2, N'Corticosterone EIA')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (3, N'
Sample Preparation')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (4, N'
Environmental Testing')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (5, N'Anatomical Pathology')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (15, N'Advanced Microscopy')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (16, N'Chemical Research')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (17, N'Sample Preparation')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (18, N'Environmental Testing')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (19, N'Anatomical Pathology')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (20, N'Advanced Microscopy')
INSERT [dbo].[ServiceTips] ([Id], [Name]) VALUES (21, N'Chemical Research')
SET IDENTITY_INSERT [dbo].[ServiceTips] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [FooterBgImage], [Signature], [Phone1], [Phone2], [Email1], [Email2], [Address], [Info], [About], [AboutImage], [Foundername], [Founderposition], [WorkHours], [MapLink]) VALUES (1, N'4cd7e746-bfa4-4182-a56d-859c0eeb5999-26February2022-logo-img.png', N'footer-map.png', N'author-sign.png', N'+123 457 7890', N'+123-456-7890', N'yourdomain@gmail.com', N'Supportteam@example.com', N'457,Gourandai Los Angeles, USA', N'A Blue Bowl, premium html5 template is the perfect solution for all kind of laboratories & laboratory based management websites. A complete package for the best online lab services.', N'Paramedical healthcare field attracts to save lives & helping people, being a doctor is not your only choice. We how else you can help patients without being a doctor, here we serving awesome opportunity.', N'single-img-six.png', N'Jhon Martin (M.L.B)', N'Chairnan and founder', N'Working Hours - Mon - Fri: 9:30 - 18:30', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3038.656418722477!2d49.878824815257055!3d40.39430687936778!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d30833d972d%3A0x47e813ce6ab12211!2sZeferan%20Hospital!5e0!3m2!1sen!2s!4v1643472845857!5m2!1sen!2s')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteSocials] ON 

INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'facebook', N'fa fa-facebook', N'facebook.com/search/top/?q=Zeferan%20hospital')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'twitter', N'fa fa-twitter', N'twitter.com/')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'google', N'fa fa-google-plus', N'google.com')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'linkedln', N'fa fa-linkedin', N'linkedin.com/')
SET IDENTITY_INSERT [dbo].[SiteSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribes] ON 

INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (2, N'aytan@gmail.com', CAST(N'2022-02-19T22:09:17.6723885' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (3, N'murad@gmail.com', CAST(N'2022-02-19T22:17:32.6757500' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (4, N'nermin@gmail.com', CAST(N'2022-02-19T22:22:57.8854676' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (5, N'gulxar@gmail.com', CAST(N'2022-02-19T22:29:12.4778008' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (6, N'inci@gmail.com', CAST(N'2022-02-19T22:50:11.5223601' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (10, N'nicat@gmail.com', CAST(N'2022-02-20T23:44:51.8150772' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (11, N'samir@gmail.com', CAST(N'2022-02-20T23:57:43.4842029' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (13, N'me@gmail.com', CAST(N'2022-02-21T18:31:26.2719440' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (14, N'mmamama@gmail.com', CAST(N'2022-02-21T19:10:28.4936221' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (15, N'nigar@gmail.com', CAST(N'2022-02-21T21:32:38.3052168' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1013, N'minnn@gmail.com', CAST(N'2022-02-25T16:09:10.3124748' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1014, N'minn@gmail.com', CAST(N'2022-02-25T16:09:39.3870796' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1015, N'min@gmail.com', CAST(N'2022-02-25T16:10:22.8851893' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1016, N'nicat@gmail', CAST(N'2022-02-25T16:10:38.0168991' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1017, N'aytanabbasova3@gmail.com', CAST(N'2022-02-26T22:26:00.6047584' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1018, N'aytanabbas98@gmail.com', CAST(N'2022-02-26T23:48:08.0234042' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1019, N'code@gmail.com', CAST(N'2022-03-03T01:15:11.5437852' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1020, N'azer@gmail.com', CAST(N'2022-03-04T00:50:08.2383785' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1021, N'aytanab@code.edu.az', CAST(N'2022-03-06T10:41:14.6045968' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1022, N'aytanab@code.edu.azefes', CAST(N'2022-03-06T10:48:28.2819639' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1023, N'llll', CAST(N'2022-03-06T13:27:34.8461416' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Subscribes] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (1, N'testimonial01.jpg', N'“Best Clinic Services Provide”', N'  I always pay attention to detail on anything that I work on to make sure, complete the task successfully.With my skill set, knowledge &amp; work ethics I could be a great                                        addition to the team to deliver the best result.', N'ALexanra May Cruz', N'CEO At Laboratory')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (2, N'testimonial02.jpg', N'“Best Clinic Services Provide”', N' A great place to work because of the opportunities for moving between centres and trying something new within your area of expertise. The laboratory is also an open and
                                        flexible workplace &amp; great place to work with.', N'Duck Peter', N'Clinical biochemist')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (3, N'testimonial02.jpg', N'“Best Clinic Services Provide”', N' The laboratory is also an open and flexible workplace &amp; great place to work with. The detail is also important, I like to ensure that I always pay attention to detail
                                        on anything that I work on.', N'John Martin', N'Psychiatrist')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (4, N'testimonial01.jpg', N'“Best Clinic Services Provide”', N' I always pay attention to detail on anything that I work on to make sure, complete the task successfully.With my skill set, knowledge &amp; work ethics I could be a great
                                        addition to the team to deliver the best result.', N'Jack Callum', N'Anesthesiologist')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (5, N'testimonial02.jpg', N'“Best Clinic Services Provide”', N' The laboratory is also an open and flexible workplace &amp; great place to work with. The detail is also important, I like to ensure that I always pay attention to detail
                                        on anything that I work on.', N'John Martin', N'Psychiatrist')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (6, N'testimonial01.jpg', N'“Best Clinic Services Provide”', N' The laboratory is also an open and flexible workplace &amp; great place to work with. The detail is also important, I like to ensure that I always pay attention to detail
                                        on anything that I work on.', N'Duck Peter', N'Clinical biochemist')
INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (7, N'testimonial02.jpg', N'“Best Clinic Services Provide”', N' A great place to work because of the opportunities for moving between centres and trying something new within your area of expertise. The laboratory is also an open and
                                        flexible workplace &amp; great place to work with.', N'Jack Callum', N'Psychiatrist')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkProcesses] ON 

INSERT [dbo].[WorkProcesses] ([Id], [BgImage], [About]) VALUES (1, N'c4ea61c0-68dd-47f8-96cc-93cbaa7a7c5c-11March2022-row-bgimage-9.png', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ev')
SET IDENTITY_INSERT [dbo].[WorkProcesses] OFF
GO
