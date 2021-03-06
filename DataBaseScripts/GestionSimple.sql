USE [GestionSimple]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Email] [varchar](320) NULL,
	[IdProvincia] [int] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](75) NULL,
	[Orden] [int] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (1, N'Abdo Ferez Federico', N'abdo@gmail.com', 5, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (2, N'Barnatan Martin Alejandro', N'barnatan@gmail.com', 1, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (3, N'Besmedrisnik Matias', N'besmedrisnik@gmail.com', NULL, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (4, N'Burstein Alanis', N'burstein@gmail.com', 2, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (5, N'Drajner Mercado Aizic Tobias Lautaro', N'drajner@gmail.com', 5, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (6, N'Falotico Galo Santiago', N'falotico@gmail.com', NULL, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (7, N'Farina Juan Pablo', N'farina@gmail.com', 4, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (8, N'Fleischer Alan', N'fleischer@gmail.com', 2, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (9, N'Grifman Uriel', N'grifman@gmail.com', 5, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (10, N'Harari Lazaro', N'harari@gmail.com', 3, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (11, N'Lombardi Cecilia', N'lombardi@gmail.com', 5, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (12, N'Marek Valentina', N'marek@gmail.com', NULL, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (13, N'Martinez Manuel', N'martinez@gmail.com', 4, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (14, N'Mester Thomas', N'mester@gmail.com', 5, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (15, N'Park Cristina Angela', N'parkc@gmail.com', 5, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (16, N'Park Steve Minha', N'parks@gmail.com', 15, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (17, N'Piva Maria Belen', N'piva@gmail.com', 6, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (18, N'Portnoi Luka Valentin', N'portnoi@gmail.com', 7, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (19, N'Roitman Marina Alejandra', N'roitman@gmail.com', 14, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (20, N'Rottman Tomy', N'rottman@gmail.com', 8, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (21, N'Salama Franco Nicolas', N'salama@gmail.com', 5, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (22, N'Schaievitch Nicolas Iair', N'schaievitch@gmail.com', 9, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (23, N'Schejvitz Dan Ezequiel', N'schejvitz@gmail.com', 5, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (24, N'Schifer Martin Nicolas', N'schifer@gmail.com', 10, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (25, N'Tacon Valentina Rocio', N'tacon@gmail.com', 5, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (26, N'Turri Gonzalo Ivo', N'turri@gmail.com', 11, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (27, N'Waisman Matias Eliel', N'waisman@gmail.com', 20, 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (28, N'Winik Tobias', N'winik@gmail.com', 21, 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [IdProvincia], [Activo]) VALUES (29, N'Zelazko Paloma', N'zelazko@gmail.com', 22, 1)
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON 

INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (1, N'Buenos Aires', 2, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (2, N'Catamarca', 3, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (3, N'Chaco', 4, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (4, N'Chubut', 5, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (5, N'Ciudad Autonoma de Buenos Aires', 1, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (6, N'Córdoba', 6, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (7, N'Corrientes', 7, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (8, N'Entre Ríos', 8, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (9, N'Formosa', 9, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (10, N'Jujuy', 10, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (11, N'La Pampa', 11, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (12, N'La Rioja', 12, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (13, N'Mendoza', 13, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (14, N'Misiones', 14, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (15, N'Neuquén', 15, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (16, N'Río Negro', 16, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (17, N'Salta', 17, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (18, N'San Juan', 18, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (19, N'San Luis', 19, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (20, N'Santa Cruz', 20, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (21, N'Santa Fe', 21, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (22, N'Santiago del Estero', 22, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (23, N'Tierra del Fuego', 23, 1)
INSERT [dbo].[Provincias] ([Id], [Nombre], [Orden], [Activo]) VALUES (24, N'Tucumán', 24, 1)
SET IDENTITY_INSERT [dbo].[Provincias] OFF
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Provincias]
GO
/****** Object:  StoredProcedure [dbo].[Personas_GetAll]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetAll]
AS
SET NOCOUNT ON
SELECT
	Personas.Id,	 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo

FROM Personas WITH (NOLOCK)
LEFT JOIN Provincias WITH (NOLOCK) ON Provincias.Id = Personas.IdProvincia

GO
/****** Object:  StoredProcedure [dbo].[Personas_GetAll_Extended]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetAll_Extended]
AS
SET NOCOUNT ON
SELECT
	Personas.Id,	 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo,
	Provincias.Nombre AS Provincias_Nombre

FROM Personas WITH (NOLOCK)
LEFT JOIN Provincias WITH (NOLOCK) ON Provincias.Id = Personas.IdProvincia

GO
/****** Object:  StoredProcedure [dbo].[Personas_GetByActivo]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetByActivo]
	@blnActivo 	Bit
AS
SET NOCOUNT ON
SELECT
	Personas.Id,	 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo

FROM Personas WITH (NOLOCK)
WHERE Personas.Activo = @blnActivo


GO
/****** Object:  StoredProcedure [dbo].[Personas_GetByActivo_Extended]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetByActivo_Extended]
	@blnActivo 	Bit
AS
SET NOCOUNT ON
SELECT
	Personas.Id,	 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo,
	Provincias.Nombre AS Provincias_Nombre

FROM Personas WITH (NOLOCK)
LEFT JOIN Provincias WITH (NOLOCK) ON Provincias.Id = Personas.IdProvincia
WHERE Personas.Activo = @blnActivo


GO
/****** Object:  StoredProcedure [dbo].[Personas_GetById]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetById]
	@intId 	Int
AS
SET NOCOUNT ON
SELECT
	Personas.Id, 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo

FROM Personas WITH (NOLOCK)
WHERE Personas.Id = @intId


GO
/****** Object:  StoredProcedure [dbo].[Personas_GetById_Extended]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Personas_GetById_Extended]
	@intId 	Int
AS
SET NOCOUNT ON
SELECT
	Personas.Id, 
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo,
	Provincias.Nombre AS Provincias_Nombre

FROM Personas WITH (NOLOCK)
LEFT JOIN Provincias WITH (NOLOCK) ON Provincias.Id = Personas.IdProvincia
WHERE Personas.Id = @intId



GO
/****** Object:  StoredProcedure [dbo].[Personas_Insert]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Personas_Insert]
	@strNombre			varchar(150) = null, 
	@strEmail			varchar(320) = null, 
	@intIdProvincia		int = null, 
	@blnActivo			bit = null
AS
--SET NOCOUNT ON
INSERT INTO Personas (
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo
)VALUES(
	@strNombre, 
	@strEmail, 
	@intIdProvincia,
	@blnActivo
)


GO
/****** Object:  StoredProcedure [dbo].[Personas_InsertScalar]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Personas_InsertScalar]
	@strNombre			varchar(150) = null, 
	@strEmail			varchar(320) = null, 
	@intIdProvincia		int = null, 
	@blnActivo			bit = null
AS
--SET NOCOUNT ON
INSERT INTO Personas (
	Personas.Nombre, 
	Personas.Email, 
	Personas.IdProvincia, 
	Personas.Activo
)VALUES(
	@strNombre, 
	@strEmail, 
	@intIdProvincia,
	@blnActivo
)

SELECT SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[Provincias_GetAll]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Provincias_GetAll]
AS
SET NOCOUNT ON
SELECT
	Provincias.Id, 
	Provincias.Nombre, 
	Provincias.Orden, 
	Provincias.Activo

FROM Provincias WITH (NOLOCK)
ORDER BY 
	Orden, 
	Nombre


GO
/****** Object:  StoredProcedure [dbo].[Provincias_GetById]    Script Date: 19/5/2021 02:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Provincias_GetById]
	@intId 	Int
AS
SET NOCOUNT ON
SELECT
	Provincias.Id, 
	Provincias.Nombre, 
	Provincias.Orden, 
	Provincias.Activo

FROM Provincias WITH (NOLOCK)
WHERE Provincias.Id = @intId


GO
