USE [HospitalDB]
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

INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (3, N'team-img01.jpg', N'Duck Peter', N'CEO At Lab', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'12+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (5, N'team-img02.jpg', N'Lexa May Cruz', N'Radiologist', N'283-456-72490', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 2)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (6, N'team-img03.jpg', N'Andrew Bon', N'Clinical biochemist', N'725-326-71590', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'14+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 3)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (7, N'team-img04.jpg', N'John Martin', N'Dentist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N' American Board of Neurological Surgery', N' Stereovctic Radiosurgery, Glioma', 4)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (8, N'team-img05.jpg', N'Thomas Charlie', N'Laboratory assistant', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'10+ Years', N' American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (9, N'team-img06.jpg', N'Lexa May Cruz', N'Psychiatrist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'8+ Years', N' American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 2)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (10, N'team-img03.jpg', N'Andrew Bon', N'Anesthesiologist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'13+ Years', N'American Board of Neurological Surgery', N' Stereovctic Radiosurgery, Glioma', 3)
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Phone], [Biography], [Experience], [Certification], [PracticeArea], [UniversityId]) VALUES (11, N'team-img02.jpg', N'Jack Callum', N'Pediatrist', N'123-456-79890', N'Mauris id enim id purus ornare tincidunt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. ean vel consequat risus.Proin viverra nisi at nisl imperdiet auctolacerat, sem mi suscipit miusce temtate ligula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas

unt. Aenean vel consequat risus.Proin viverra nisi at nisl imperdiet auctor. Donec ornare, est sed tincidunt placerat, sem mi suscipit mi, at varius enim sem at sem. Fusce tempus ex nibh, eget vulputate ligula ornare eget. Nunc facilisn viverra nisi at nisl ugula ornare eget. Nunc facilisis erat at ligula blandit tempor. maecenas', N'6+ Years', N'American Board of Neurological Surgery', N'Stereovctic Radiosurgery, Glioma', 1)
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Researches] ON 

INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (2, N'01.jpg', N'
 
Fitness Guidance to Patient', N'John Michael', CAST(N'2019-04-20T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', N'services-03.jpg', 1)
INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (5, N'02.jpg', N'
 
Diagnostic Imagine', N'Duck Peter', CAST(N'2018-08-14T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Nemo enim ipsam voluptatem quia voluptas atus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making.

There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model', N'services-03.jpg', 2)
INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (8, N'03.jpg', N'
Orthodontics Surgery', N'Lexa May Cruz', CAST(N'2021-04-22T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', N'services-03.jpg', 3)
INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (12, N'04.jpg', N'
 
Rehabilitation Center', N'John Martin', CAST(N'2008-02-10T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', N'services-03.jpg', 4)
INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (13, N'05.jpg', N'Blood Pressure Checkup', N'Andrew Bon', CAST(N'2015-06-05T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', N'services-03.jpg', 5)
INSERT [dbo].[Researches] ([Id], [MainImage], [Title], [Client], [CreatedDate], [Location], [Details], [Advantages], [DetailImage], [CatId]) VALUES (15, N'06.jpg', N'Dentures / Partial Dentures', N'Jack Callum', CAST(N'2017-03-25T00:00:00.0000000' AS DateTime2), N'Bulls Stadium, Califorina', N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of “de Finibus Bonorum et Malorum” (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics,', N'There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don’t look even slightly believable. If you are going to use a passage ssing hidden in the middle of text. of Lorem Ipsum, you need to be sure there isn’t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model.', N'services-03.jpg', 1)
SET IDENTITY_INSERT [dbo].[Researches] OFF
GO
SET IDENTITY_INSERT [dbo].[ResearchImages] ON 

INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (2, N'01.jpg', 2)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (3, N'02.jpg', 2)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (4, N'03.jpg', 2)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (5, N'04.jpg', 2)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (6, N'01.jpg', 5)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (7, N'02.jpg', 5)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (8, N'03.jpg', 5)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (9, N'04.jpg', 5)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (10, N'01.jpg', 8)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (11, N'02.jpg', 8)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (12, N'03.jpg', 8)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (13, N'04.jpg', 8)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (14, N'01.jpg', 12)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (15, N'02.jpg', 12)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (16, N'03.jpg', 12)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (17, N'04.jpg', 12)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (18, N'01.jpg', 13)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (19, N'02.jpg', 13)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (20, N'03.jpg', 13)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (21, N'04.jpg', 13)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (22, N'01.jpg', 15)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (23, N'02.jpg', 15)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (24, N'03.jpg', 15)
INSERT [dbo].[ResearchImages] ([Id], [Name], [ResearchId]) VALUES (25, N'04.jpg', 15)
SET IDENTITY_INSERT [dbo].[ResearchImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (1, N'Sample Preparation', N'88%
')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (2, N'Environmental Testing', N'96%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (3, N'Advanced Microscopy', N'
90%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (4, N'Environmental Testing', N'
96%')
INSERT [dbo].[Skills] ([Id], [Name], [Percent]) VALUES (5, N'Advanced Microscopy
', N'90%')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillToTeams] ON 

INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (1, 3, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (2, 3, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (3, 3, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (4, 3, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (5, 3, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (6, 5, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (7, 5, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (8, 5, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (9, 5, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (10, 5, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (11, 6, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (12, 6, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (13, 6, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (14, 6, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (15, 6, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (16, 7, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (17, 7, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (18, 7, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (19, 7, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (20, 7, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (21, 8, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (22, 8, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (23, 8, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (24, 8, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (25, 8, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (26, 9, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (27, 9, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (28, 9, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (29, 9, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (30, 9, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (31, 10, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (32, 10, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (33, 10, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (34, 10, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (35, 10, 5)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (36, 11, 1)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (37, 11, 2)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (38, 11, 3)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (39, 11, 4)
INSERT [dbo].[SkillToTeams] ([Id], [TeamId], [SkillId]) VALUES (40, 11, 5)
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
SET IDENTITY_INSERT [dbo].[TeamExperiences] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamSocials] ON 

INSERT [dbo].[TeamSocials] ([Id], [Name], [Icon], [Link], [TeamId]) VALUES (1, N'facebook', N'fa fa-facebook', NULL, 3)
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
SET IDENTITY_INSERT [dbo].[TeamSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[AboutResearches] ON 

INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (1, N'Central Forensic Science', N'01', N'Forensic science is a discipline that applies scientific analysis to the justice system, help prove the events of crime')
INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (2, N'Clinical & Medical Laboratory', N'02', N'Conducts lab tests ordered by doctors. Working with laboratory machines as we examine human tissue samples & diagnose')
INSERT [dbo].[AboutResearches] ([Id], [Title], [Number], [Content]) VALUES (3, N'Analytical & Quality Laboratory', N'03', N'The Various techniques that we are used to identifying the chemical makeup and characteristics of a particular samples')
SET IDENTITY_INSERT [dbo].[AboutResearches] OFF
GO
SET IDENTITY_INSERT [dbo].[Accordions] ON 

INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (8, N'How Should I Beleive About Your Services?', N'
It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'blog-five-740x504.jpg')
INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (9, N'What Are Laboratory Tests?
', N'It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'blog-five-740x504.jpg')
INSERT [dbo].[Accordions] ([Id], [Question], [Description], [Image]) VALUES (10, N'Who performs the testing on laboratory specimens?', N'
It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.', N'blog-five-740x504.jpg')
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
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (1, N'About Us', N'About Us', N'About', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (2, N'Services', N'Services', N'Service', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (3, N'Team ', N'Team', N'Team', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (4, N'Team Details', N'Team Details', N'TeamDetail', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (5, N'Research ', N'Research ', N'Research ', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (6, N'Research Details', N'Research Details', N'ResearchDetail', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (7, N'Contact Us', N'Contact Us', N'ContactUs', N'about-bg.jpg')
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (8, N'Faq', N'Faq', N'Faq', N'about-bg.jpg')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[BgImages] ON 

INSERT [dbo].[BgImages] ([Id], [TestimonialBgImage], [AccordionBgImage], [ServiceBgImage], [FutureBgImage]) VALUES (1, N'row-bgimage-6.jpg', N'row-bgimage-7.jpg', N'row-bgimage-5.png', N'row-bgimage-4.png')
SET IDENTITY_INSERT [dbo].[BgImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Cardiology')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Orthopedics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Pharmacy')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Anestheslology')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Pediatric')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Chooses] ON 

INSERT [dbo].[Chooses] ([Id], [BgImage], [About]) VALUES (1, N'row-bgimage-8.jpg', N'Our excellent team is ready to be part of your team to work into the different areas of diagnoses. Scientists helping scientists.')
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

INSERT [dbo].[HomeSliders] ([Id], [Image], [Title], [Subtitle]) VALUES (1, N'slider-mainbg-005.jpg', N'Research & Verify A  Physics Laboratory', N'Labostica is uatramodern laboratory services. Delivering newer')
INSERT [dbo].[HomeSliders] ([Id], [Image], [Title], [Subtitle]) VALUES (2, N'slider-mainbg-006.jpg', N'Professional Family Health Care', N'Labostica is Ulatramodern Laboratory Services')
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

INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (1, N'Data Collection', N'fal fa-flask', N'01', N'For the accurate diagnoses, perfect information is must require', N'arrow-1.png')
INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (2, N'Diagnose Process', N'fas fa-microscope', N'02', N'The collection goes to the particular department for the tests', N'arrow-2.png')
INSERT [dbo].[ProcessPlans] ([Id], [Title], [Icon], [Number], [Content], [ArrowImage]) VALUES (3, N'Access To Reports', N'fal fa-dna', N'03', N'As a result, that arrive one can access their report online or direct ', NULL)
SET IDENTITY_INSERT [dbo].[ProcessPlans] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceAbouts] ON 

INSERT [dbo].[ServiceAbouts] ([Id], [Image], [Title], [About]) VALUES (6, N'single-img-ten.png', N'We Employ The Latest Research Technology & Company', N'Paramedical healthcare field attracts to save lives & helping people, being a doctor is not your only choice. We how else you can help patients without being a doctor, here we serving awesome opportunity.
well-established experience in epitomizing good laboratory medicine practices & treating the patients with utmost diligence')
SET IDENTITY_INSERT [dbo].[ServiceAbouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Image], [Content], [Phone], [Experience], [Title]) VALUES (1, N'single-img-four.jpg', N'Our scientists and engineers focus their extreme curiosity on national & health related challenges. Learn more about the Laboratory’s work below segment.', N'+123-456-7890', N'20 Years', N'We Are Laboratory Technologies')
SET IDENTITY_INSERT [dbo].[Services] OFF
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

INSERT [dbo].[Settings] ([Id], [Logo], [FooterBgImage], [Signature], [Phone1], [Phone2], [Email1], [Email2], [Address], [Info], [About], [AboutImage], [Foundername], [Founderposition], [WorkHours], [MapLink]) VALUES (1, N'logo-img.png', N'footer-map.png', N'author-sign.png', N'+123 456 7890', N'+123-456-7890', N'yourdomain@gmail.com', N'Supportteam@example.com', N'457,Gourandai Los Angeles, USA', N'A Blue Bowl, premium html5 template is the perfect solution for all kind of laboratories & laboratory based management websites. A complete package for the best online lab services.', N'Paramedical healthcare field attracts to save lives & helping people, being a doctor is not your only choice. We how else you can help patients without being a doctor, here we serving awesome opportunity.', N'single-img-six.png', N'Jhon Martin (M.L.B)', N'Chairnan and founder', N'Working Hours - Mon - Fri: 9:30 - 18:30', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3038.656418722477!2d49.878824815257055!3d40.39430687936778!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d30833d972d%3A0x47e813ce6ab12211!2sZeferan%20Hospital!5e0!3m2!1sen!2s!4v1643472845857!5m2!1sen!2s')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteSocials] ON 

INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'facebook', N'fa fa-facebook', NULL)
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'twitter', N'fa fa-twitter', NULL)
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'google', N'fa fa-google-plus', NULL)
INSERT [dbo].[SiteSocials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'linekdln', N'fa fa-linkedin', NULL)
SET IDENTITY_INSERT [dbo].[SiteSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([Id], [Image], [Quote], [Description], [Fullname], [Profession]) VALUES (1, N'testimonial01.jpg', N'“Best Clinic Services Provide”', N'  I always pay attention to detail on anything that I work on to make sure, complete the task successfully.With my skill set, knowledge &amp; work ethics I could be a great
                                        addition to the team to deliver the best result.', N'ALexanra May Cruz', N'CEO At Laboratory')
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

INSERT [dbo].[WorkProcesses] ([Id], [BgImage], [About]) VALUES (1, N'row-bgimage-9.png', N'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry''s standard dummy text ev')
SET IDENTITY_INSERT [dbo].[WorkProcesses] OFF
GO
