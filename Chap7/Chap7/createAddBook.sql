USE pr_cs_sampleDB
GO
IF EXISTS(SELECT * FROM sys.objects 
	WHERE type = 'P' AND name = 'AddBook')
	DROP PROCEDURE AddBook
GO
CREATE PROCEDURE AddBook
	@book_id varchar(6),
	@book_title varchar(80),
	@book_type char(12),
	@book_price money,
	@book_pubdate datetime,
	@sum_of_book_prices money OUTPUT
AS
BEGIN
	INSERT INTO books (BOOK_ID,TITLE,TYPE,PRICE,PUBDATE)
	VALUES (@book_id,@book_title,@book_type,
			@book_price,@book_pubdate);
	SELECT @sum_of_book_prices = sum(PRICE) from books
	DECLARE @count_books int
	SELECT @count_books = count(*) from books 
	RETURN @count_books
END;
GO