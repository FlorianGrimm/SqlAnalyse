DECLARE @c NVARCHAR(max) = 'ce';
SELECT a, b, c=@c  FROM dbo.t;