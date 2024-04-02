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

       (2,'5L', 16, 3,    2,  10,   -2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke'),
       (2,'5M', 32, 7,    6,  10,    1,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke'),
       (2,'5H', 40, 11,   7,  14,   -4,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke'),
       (2,'2L', 16, 5,    2,  10,   -2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(LOW BLOCK)'),
       (2,'2M', 22, 10,   4,  17,   -7,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke(LOW BLOCK)'),
       (2,'2H', 30, 10,   8,  24,   -12,     'WIP',    'WIP', 'WIP', 'WIP',  'A ninja star attack that sends the opponent flying upwards'),
       (2,'6L', 22, 9,    5,  25,   -16,     'WIP',    'WIP', 'WIP', 'WIP',  'An average light anti-air'),
       (2,'6M', 35, 20,   5,  7,     2,      'WIP',    'WIP', 'WIP', 'WIP',  'Throws a kunai to hit their opponent (HIGH BLOCK)'),
       (2,'6H', 40, 14,   6,  18,   -4,      'WIP',    'WIP', 'WIP', 'WIP',  'A hard hititng finisher attack'),
       (2,'8L', 16, 5,    4,  8,     2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(HIGH BLOCK)'),
       (2,'8M', 26, 8,    4,  18,    1,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke(HIGH BLOCK)'),
       (2,'8H', 36, 10,   10, 14,    3,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke(HIGH BLOCK)'),

       (3,'5L', 26, 7,    3,  6,     3,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke'),
       (3,'5M', 37, 9,    6,  12,    1,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke'),
       (3,'5H', 45, 17,   6,  15,   -2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke'),
       (3,'2L', 26, 6,    3,  6,     3,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(LOW BLOCK)'),
       (3,'2M', 32, 13,   6,  12,   -4,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke(LOW BLOCK)'),
       (3,'2H', 44, 20,   4,  26,   -13,     'WIP',    'WIP', 'WIP', 'WIP',  'An attack that sends the opponent flying upwards'),
       (3,'6L', 30, 12,   6,  27,   -19,     'WIP',    'WIP', 'WIP', 'WIP',  'An average light anti-air'),
       (3,'6M', 40, 20,   10, 18,     4,      'WIP',    'WIP', 'WIP', 'WIP',  'A big hit (HIGH BLOCK)'),
       (3,'6H', 60, 25,   20, 18,     4,      'WIP',    'WIP', 'WIP', 'WIP',  'A hard hititng finisher attack'),
       (3,'8L', 18, 6,    3,  12,     0,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(HIGH BLOCK)'),
       (3,'8M', 25, 9,    7,  10,     4,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke(HIGH BLOCK)'),
       (3,'8H', 32, 12,   5,  20,     0,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke(HIGH BLOCK)'),

       (4,'5L', 20, 5,    3,  7,     -2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke'),
       (4,'5M', 29, 7,    6,  10,     1,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke'),
       (4,'5H', 40, 14,   5,  26,    -9,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke'),
       (4,'2L', 19, 4,    3,  9,     -2,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(LOW BLOCK)'),
       (4,'2M', 30, 13,   6,  15,    -7,      'WIP',    'WIP', 'WIP', 'WIP',  'Tosses marbles on the floor(LOW BLOCK)'),
       (4,'2H', 40, 18,   6,  15,    -4,     'WIP',    'WIP', 'WIP', 'WIP',  'An attack that sends the opponent flying upwards'),
       (4,'6L', 26, 9,    4,  20,   -10,     'WIP',    'WIP', 'WIP', 'WIP',  'An average light anti-air'),
       (4,'6M', 35, 20,   5,   7,     2,      'WIP',    'WIP', 'WIP', 'WIP',  'A medium hit (HIGH BLOCK)'),
       (4,'6H', 50, 25,   9,  25,   -15,      'WIP',    'WIP', 'WIP', 'WIP',  'A hard hititng finisher attack'),
       (4,'8L', 16, 6,    4,   9,     0,      'WIP',    'WIP', 'WIP', 'WIP',  'An average light poke(HIGH BLOCK)'),
       (4,'8M', 25, 11,   6,  18,     0,      'WIP',    'WIP', 'WIP', 'WIP',  'An average medium poke(HIGH BLOCK)'),
       (4,'8H', 30, 13,   4,  12,     0,      'WIP',    'WIP', 'WIP', 'WIP',  'An average heavy poke(HIGH BLOCK)');


SELECT * FROM dbo.Character
SELECT * FROM dbo.Move