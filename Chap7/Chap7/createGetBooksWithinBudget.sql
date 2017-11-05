USE pr_cs_sampleDB
GO
IF EXISTS(SELECT * FROM sys.objects 
WHERE type = 'P' AND name = 'GetBooksWithinBudget')
	DROP PROCEDURE GetBooksWithinBudget
GO
CREATE PROCEDURE GetBooksWithinBudget
	@mymoney money = 0
AS
	SELECT B.TITLE, 
	stuff((SELECT ', ' + A.NAME FROM bookauthor AS BA 
	INNER JOIN authors AS A ON A.AUTHOR_ID = BA.AUTHOR_ID
	WHERE BA.BOOK_ID = B.BOOK_ID for xml path('')), 1, 1, '') 
	AS AUTHORS, PRICE
	FROM books AS B
	WHERE PRICE<=@mymoney;
GO