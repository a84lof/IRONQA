-- GET USER APPRAISALS
SELECT * FROM OGREPO.dbo.APPRAISAL
WHERE UserID = '189712'

-- GET DEALER APPRAISALS
SELECT * FROM OGREPO.dbo.APPRAISAL
WHERE UserID in (
    SELECT userID FROM AUTH.dbo.Users_Master
    WHERE DealerNo = '8772664766'
) ORDER By DateCreated DESC

-- GET APPRAISAL DETAIL
SELECT * FROM OGREPO.dbo.AppraisalDetail
WHERE AppraisalID IN (
    SELECT AppraisalID FROM OGREPO.dbo.Appraisal
    WHERE userID = '189712'
) ORDER BY DateUpdated DESC

-- GET VARIABLE USAGE ADJ
SELECT dbo.GPUB_getVariableUsageDollarAdjustment(CAST('2020-10-10' AS DATE), 'TR', '2008', '100', 'CHLGR','MT945B', 'A', 'AG')


-- GET APPRAISAL COMPARING TG VS OG DATA
SELECT TOP 1000 p.Region as TG_Region
, p.Type as TG_Type, p.Make as TG_Make, p.Model as TG_Model, p.[Year] as TG_Year, p.Avg_Hours as TG_AVG
, ppv.PublishedAverageMeter as OG_AVG, p.Hour_Adjust as TG_$PerMeter, ppv.Meter$Adjustment as OG_$PerMeter
, ppv.AverageWholesale as OG_Wholesale, ppv.TradeRough as OG_TradeRough, ppv.TradePremium as OG_TradePremium
, ppv.ResaleCash as OG_ResaleCash, ppv.RetailAdvertised as OG_Advertised, ppv.AverageReconditioning as OG_AvgReconditioning
FROM TRADEGUIDE..TG_PRICE p
INNER JOIN OGREPO..OG_IssueCalendar ic ON p.region = ic.IssueRegionCode
INNER JOIN TRADEGUIDE..TG_Master m ON p.Model_Key = m.Model_Key
INNER JOIN OGREPO..og_product pr ON m.Model_Key = pr.ModelKey
INNER JOIN OGREPO..OG_ProductYear py ON pr.ProductID = py.ProductID AND py.year = p.[Year]
INNER JOIN ogrepo..PublishedProductValues ppv ON ppv.ProductYearID = py.ProductYearID AND ppv.IssueID = ic.IssueID
WHERE ic.IssueName = 'Spring 2019'
AND ic.GuideIndustry = 'AG'
AND p.Region in ('A')
AND p.year NOT IN ('XX','X','All')
AND p.Type = 'CO' --Enter Type Code
AND p.Make = 'JD' --Enter Make Code
AND p.Model = 'S670' --Enter Model
AND p.[Year] = '2017' --Enter Year
