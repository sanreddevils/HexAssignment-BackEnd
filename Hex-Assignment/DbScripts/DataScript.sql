-- populating User_Master table
INSERT INTO USER_MASTER
SELECT 'san@test.com','!QAZ2wsx'

-- populating SoftSkillslookup
INSERT INTO SOFTSKILL_AREA
SELECT 'Learning Ability'
UNION
SELECT 'Adaptability'
UNION
SELECT 'Problem Solving'
UNION
SELECT 'Dependability'
UNION 
SELECT 'Teamwork'
UNION 
SELECT 'Creativity'
UNION 
SELECT 'Listening Ability'
UNION 
SELECT 'Communication'
UNION 
SELECT 'Research Skills'
UNION 
SELECT 'Responsibility'

--populating selfrating

INSERT INTO USER_SKILL_RATING
SELECT 1,1,8
UNION
SELECT 1,2,7
UNION
SELECT 1,3,8
UNION
SELECT 1,4,8
UNION
SELECT 1,5,9
UNION
SELECT 1,6,8
UNION
SELECT 1,7,7
UNION
SELECT 1,8,8
UNION
SELECT 1,9,8
UNION
SELECT 1,10,9
