USE master
GO 

IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'MOVELIST')

BEGIN DROP Database MOVELIST
END

CREATE DATABASE MOVELIST
GO

USE MOVELIST
GO

DROP TABLE IF EXISTS Character
GO

CREATE TABLE Character (
	CharacterId		INT			 IDENTITY(1,1)	PRIMARY KEY,
	CharacterName	VARCHAR(255) NOT NULL,
	Health			INT			 NOT NULL,
	JumpHeight		INT			 NOT NULL,
	Description		VARCHAR(255) NULL
);

DROP TABLE IF EXISTS Move
GO

CREATE TABLE Move(
	MoveId			INT			IDENTITY(1,1)	PRIMARY KEY,
	InputName		VARCHAR(10)	NOT NULL,
	Damage			INT			NOT NULL,
	StartupFrames	INT			NOT NULL,
	ActiveFrames	INT			NOT NULL,
	RecoveryFrames	INT			NOT NULL,
	OnBlock			INT			NOT NULL,
	HitBoxSize		INT			NOT NULL,
	HitBoxPos		INT			NOT NULL,
	HurtBoxSize		INT			NOT NULL,
	HurtBoxPos		INT			NOT NULL,
	Description		VARCHAR(255)NULL
);

ALTER TABLE Move
ADD CONSTRAINT FK_Move_Character FOREIGN KEY (CharacterId)
REFERENCES Character(CharacterId);

SET IDENTITY_INSERT Character ON  
INSERT INTO Character (CharacterId,CharacterName,Health,JumpHeight,Description) VALUES(1,'Nina',400,600,'A character with average speed good damage and tons of tools')
INSERT INTO Character (CharacterId,CharacterName,Health,JumpHeight,Description) VALUES(2,'Suzie',320,600,'A fast and fragile charater capable of mixing the opponent up quick')
INSERT INTO Character (CharacterId,CharacterName,Health,JumpHeight,Description) VALUES(3,'Leo',450,500,'A mighty king huge in size and massive in damage.')
INSERT INTO Character (CharacterId,CharacterName,Health,JumpHeight,Description) VALUES(4,'Charlie',400,600,'A jester with some rng added into the mix')
SET IDENTITY_INSERT Character OFF

SELECT * FROM Character

SET IDENTITY_INSERT Move ON  
INSERT INTO Move (MoveId,InputName,Damage,StartupFrames,ActiveFrames,RecoveryFrames,OnBlock,HitBoxSizeX,HitBoxSizeY,HitBoxPosX,HitBoxPosY,HurtBoxSizeX,HurtBoxSizeY,HurtBoxPosX,HurtBoxPosY,Description)
			VALUES(1,'5L',20,5,5,7,-2,100,50,60,-30,160,370,-40,0,'An average light poke')
SET IDENTITY_INSERT Move OFF

SELECT * FROM Move