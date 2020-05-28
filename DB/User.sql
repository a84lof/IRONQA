
-- GET USER FEATURES
SELECT userId, c.featureName, a.EventCode, c.featureDescription, f.* 
FROM auth..usersApiFeatures f
INNER JOIN config..configApiFeature c ON c.apiFeatureId = f.apiFeatureId
INNER JOIN config..ApplicationEvent a on c.apiFeatureId = a.apiFeatureId
WHERE userId IN ('189712')
AND dateExpires >= getdate()

-- GET USER ROLES
SELECT c.roleName, c.roleDescription, r.*
FROM auth..usersApiRoles r
INNER JOIN config..configApiRole c ON r.apiRoleId = c.apiRoleId
WHERE userId IN ('191110')

-- GET USERS_MASTER INFO
SELECT userId, dealerno, email, *
FROM auth..users_master
--WHERE userId = '206519'
WHERE email = 'proinvadmin@usigqa.com'

-- GET USER ATTRIBUTES
SELECT * FROM auth..UsersAttributes
WHERE userId IN (
    SELECT userID FROM auth..users_master
    WHERE userId = '200021'
)

-- GET USER FARMER INFO
SELECT * FROM auth..UserFarmer
WHERE userID = '206251'

-- GET DEALER INFO
SELECT * FROM caps..dealers
WHERE dealer_no = '8772664766'

-- GET DEALER FEATURES
SELECT DISTINCT c.featureName, a.EventCode, c.featureDescription 
FROM auth..usersApiFeatures f
INNER JOIN config..configApiFeature c ON c.apiFeatureId = f.apiFeatureId
INNER JOIN config..ApplicationEvent a on c.apiFeatureId = a.apiFeatureId
WHERE userID IN (
  SELECT userID FROM auth..users_master 
  WHERE DealerNo = '6152222222' 
)

-- CHECK USAGE LOGS
SELECT l.DealerNo, l.UserId, l.EventDate, c.EventDesc, l.EventId, l.EventCode 
FROM logs..AppEventLog l
INNER JOIN config..ApplicationEvent c ON l.ApplicationCode = c.ApplicationCode AND l.eventcode=c.eventcode
WHERE dealerNo = '3863853660'

-- CHECK ERROR LOGS
SELECT TOP 100 * FROM LOGS..AppErrors
WHERE Username = 'brandon.nfltractor'

SELECT * FROM LOGS..GuidesPlatformLogs
WHERE ErrorMessage like '%%'


-- CHECK APPRAISALS
SELECT a.UserId, c.featureName, a.AppraisalId, p.[Type], p.Make, p.Model, py.[Year], a.DateCreated FROM OGREPO..Appraisal a
INNER JOIN CONFIG..ConfigApiFeature c ON a.ApiFeatureID = c.apiFeatureId
INNER JOIN OGREPO..AppraisalDetail ad ON a.AppraisalID = ad.AppraisalID
INNER JOIN OGREPO..PublishedProductValues ppv ON a.PublishedProductValueID = ppv.PublishedProductValueID
INNER JOIN OGREPO..OG_ProductYear py ON ppv.ProductYearID = py.ProductYearID
INNER JOIN OGREPO..OG_Product p ON py.ProductID = p.ProductID
WHERE a.UserId IN (
    SELECT UserId FROM AUTH..Users_Master
    WHERE DealerNo = '0000000343'
)
AND a.DateCreated >= '2019-01-01'
AND c.featureName = 'BasicAgApi'
ORDER By a.DateCreated Desc

-- ALL USER FEATURES
SELECT * FROM config..ConfigApiFeature
-- ALL USER ROLES
SELECT * FROM config..configApiRole
-- GET ALL APPLICATION EVENT CODES (REDIS)
SELECT * FROM config..ApplicationEvent



