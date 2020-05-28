-- GET EQUIPMENT
SELECT * FROM IRONSEARCH.dbo.Equip
WHERE IW_No = '3346477'

-- GET DELETED EQUIPMENT
SELECT * FROM IRONSEARCH.DBO.EQUIP_DELETED
WHERE IW_NO = '3346477'

-- GET EQUIP STATUS
SELECT * FROM IRONSEARCH.DBO.CONFIG_EQUIP_STATUS

--GET METERS
SELECT * FROM IRONSEARCH.dbo.Equip_Size
WHERE IW_No = '3346477'

-- GET IMAGES
SELECT * FROM IRONSEARCH.DBO.EQUIP_IMAGES
WHERE IW_NO = '3346417'

-- CHECK GUIDES LOGS
SELECT TOP 100 * 
FROM LOGS..GuidesPlatformLogs 
ORDER BY EventDateTime DESC

-- CONFIRM EQUIPMENT UPLOADED
SELECT * FROM LOGS.dbo.BatchProcessingGroup
WHERE BatchProcessingGroupId = 161 -- insert batch id from postman response
AND BatchProcessingGroupTypeId = 2


SELECT bpi.* FROM LOGS.dbo.BatchProcessingItem bpi
WHERE bpi.BatchProcessingGroupId = 68 -- where batchId is the BatchProcessingGroupId from the query abov


SELECT * FROM LOGS.dbo.BatchProcessingGroup
WHERE BatchProcessingGroupTypeId = 2
ORDER BY BatchProcessingGroupId DESC 



select * from caps.dbo.dealers where company like '%Dragoon%'
