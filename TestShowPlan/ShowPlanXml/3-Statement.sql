IF (object_id('dbo.t') is not null) BEGIN
	SELECT c.a, b = c.b, c= 1  FROM dbo.t as c; 
END ELSE BEGIN 
	SELECT b,a,c=2  FROM dbo.t;
END;
SELECT b,a,c=3  FROM dbo.t;