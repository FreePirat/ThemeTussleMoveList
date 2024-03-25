USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'MOVELIST')
BEGIN
    DROP DATABASE MOVELIST
END
GO

CREATE DATABASE MOVELIST
GO

USE MOVELIST
GO

DROP TABLE IF EXISTS dbo.Character
GO

CREATE TABLE dbo.Character (
    CharacterId     INT          IDENTITY(1,1) PRIMARY KEY,
    CharacterName   VARCHAR(255) NOT NULL,
    Health          INT          NOT NULL,
    JumpHeight      INT          NOT NULL,
    Description     VARCHAR(255) NULL
);

DROP TABLE IF EXISTS dbo.Move
GO

CREATE TABLE dbo.Move (
    MoveId          INT          IDENTITY(1,1) PRIMARY KEY,
    CharacterId     INT          NOT NULL,
    InputName       VARCHAR(10)  NOT NULL,
    Damage          INT          NOT NULL,
    StartupFrames   INT          NOT NULL,
    ActiveFrames    INT          NOT NULL,
    RecoveryFrames  INT          NOT NULL,
    OnBlock         INT          NOT NULL,
    HitBoxSize      VARCHAR(10)  NOT NULL,
    HitBoxPos       VARCHAR(10)  NOT NULL,
    HurtBoxSize     VARCHAR(10)  NOT NULL,
    HurtBoxPos      VARCHAR(10)  NOT NULL,
    Description     VARCHAR(255) NULL
);

INSERT INTO dbo.Character (CharacterName, Health, JumpHeight, Description)
VALUES ('Nina', 400, 600, 'A character with average speed good damage and tons of tools'),
       ('Suzie', 320, 600, 'A fast and fragile character capable of mixing the opponent up quick'),
       ('Leo', 450, 500, 'A mighty king huge in size and massive in damage.'),
       ('Charlie', 400, 600, 'A jester with some RNG added into the mix');

INSERT INTO dbo.Move (CharacterId, InputName, Damage, StartupFrames, ActiveFrames, RecoveryFrames, OnBlock, HitBoxSize, HitBoxPos, HurtBoxSize, HurtBoxPos, Description)
VALUES (1,'5L', 20, 5,   5, 7,   -2,     '100, 50',    '60, -30', '160, 370', '-40, 0',  'An average light poke'),
       (1,'5M', 38, 7,   8, 10,   1,     '100, 70',    '60,  90', '160, 370', '-40, 0',  'An average medium poke'),
       (1,'5H', 45, 12,  5, 28,  -15,    '150, 100',   '30, -30', '160, 370', '-40, 0',  'An average heavy poke'),
       (1,'2L', 18, 5,   4, 9,   -2,     '90,  50',    '60,  30', '160, 300', '-15, 20', 'An average light poke(LOW BLOCK)'),
       (1,'2M', 30, 8,   4, 21,  -10,    '130, 55',    '50, 130', '160, 300', '-15, 20', 'An average medium poke(LOW BLOCK)'),
       (1,'2H', 36, 12,  9, 22,  -14,    '120, 90',    '40,   0', '160, 370', '-15, 20', 'An attack that sends the opponent flying upwards'),
       (1,'6L', 28, 11,  6, 17,  -9,     '160, 145',   '30, -60', '160, 180', '-40, 70', 'An average light anti-air'),
       (1,'6M', 35, 20,  5, 7,    2,     '105, 80',    '70, -30', '160, 370', '-40, 0',  'Nina flicks a coin to hit their opponent (HIGH BLOCK)'),
       (1,'6H', 50, 17,  5, 15,  -6,     '140, 150',   '30, -30', '160, 370', '-40, 0',  'A hard hititng finisher attack'),
       (1,'8L', 20, 5,   5, 10,   0,     '60,  65',    '70,   0', '160, 300',   '0, 0',  'An average light poke(HIGH BLOCK)'),
       (1,'8M', 24, 8,   4, 10,   0,     '70,  70',    '50,  40', '160, 300',   '0, 0',  'An average medium poke(HIGH BLOCK)'),
       (1,'8H', 38, 12,  4, 18,   0,     '90,  105',   '15,  15', '160, 300',   '0, 0',  'An average heavy poke(HIGH BLOCK)'),

       (2,'5L', 20, 5,   5, 7,   -2,     '100, 50',    '60, -30', '160, 370', '-40, 0',  'An average light poke');

SELECT * FROM dbo.Character
SELECT * FROM dbo.Move