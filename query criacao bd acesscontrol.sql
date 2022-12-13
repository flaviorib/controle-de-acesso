USE ACESS CONTROL


CREATE TABLE [dbo].[funcionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome_funcionario] [varchar](50) NOT NULL,
	[celular_funcionario] [varchar](15) NOT NULL,
	[rg_funcionario] [varchar](50) NULL,
	[cpf_funcionario] [char](14) NULL,
	[cargo_funcionario] [varchar](100) NOT NULL,
	[foto_funcionario] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/** Object:  Table [dbo].[animal]    Script Date: 03/05/2020 14:46:16 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visitante](
	[codigo_visitante] [int] IDENTITY(1,1) NOT NULL,
	[nome_visitante] [varchar](50) NOT NULL,
	[rg_visitante] [char](10) NOT NULL,
	[cpf_visitante] [char](1) NOT NULL,
	[foto_visitante] [image](25)  NULL
	
PRIMARY KEY CLUSTERED 
(
	[codigo_visitante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/** Object:  Table [dbo].[agendamento]    Script Date: 03/05/2020 14:46:16 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[endereco](
	[id_endereco] [int] IDENTITY(1,1) NOT NULL,
	[ent_data] [date] NOT NULL,
	[ent_horario] [time](7) NOT NULL,
	[sai_data] [date] NOT NULL,
	[sai_horario] [time](7) NOT NULL,
	[ag_total] [numeric](5, 2) NOT NULL
PRIMARY KEY CLUSTERED 
(
	[id_endereco] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/** Object:  Table [dbo].[agendamento_servicos]    Script Date: 03/05/2020 14:46:16 **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[funcionario] ([id_funcionario])
GO
/****** Object:  ForeignKey [FK__animal__ani_raca__09DE7BCC]    Script Date: 03/05/2020 14:46:16 ******/
ALTER TABLE [dbo].[endereco]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
