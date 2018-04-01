--Creating DB
CREATE DATABASE [Hex-DB]

----Creating Table USER_MASTER
CREATE TABLE USER_MASTER
(
ID INT Primary KEY IDENTITY(1,1),
Email nvarchar(127) not null,
[Password] nvarchar(127) not null
)

----Creating Table SOFTSKILL_AREA
CREATE TABLE SOFTSKILL_AREA
(
ID INT Primary KEY IDENTITY(1,1),
SkillSet nvarchar(63) not null
)
----Creating Table USER_SKILL_RATING
CREATE TABLE USER_SKILL_RATING
(
USERID INT,
SKILLSETID INT,
SKILLSETVALUE INT
)
ALTER TABLE USER_SKILL_RATING
ADD CONSTRAINT FK_USER_MASTER_UserID FOREIGN KEY (UserID)
    REFERENCES USER_MASTER(ID);
ALTER TABLE USER_SKILL_RATING
ADD CONSTRAINT FK_SOFTSKILL_AREA_UserID FOREIGN KEY (SKILLSETID)
    REFERENCES SOFTSKILL_AREA(ID);