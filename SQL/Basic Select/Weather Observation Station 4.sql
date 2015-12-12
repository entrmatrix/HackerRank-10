DECLARE @TotalCount int;
DECLARE @UniqueCount int;

SELECT @TotalCount = COUNT(*) FROM [STATION];
SELECT @UniqueCount = COUNT(DISTINCT([CITY])) FROM [STATION];

SELECT @TotalCount - @UniqueCount;