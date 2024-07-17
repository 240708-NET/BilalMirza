-- SQL Notes

-- Comments in SQL are noted with a "--"

/*
multi-line comments are a thing as well
see?
*/

-- DDL Data Definition - Creating and modifying the structure of the data/tables/database
-- DQL Data Query - Retrieving the data in interesting ways
-- DML Data Mainpulation - Creating and modifying the data inside 
-- DCL Data Control - Access control, and server administration

-- ************** DQL **************
-- SELECT - sorting, filtering, and gathering data from tables with 

-- CREATE DATABASE MyDatabase;
-- USE MyDatabase;
-- GO

SELECT 2; -- Select always returns a table
SELECT 2 + 2; -- the server can be pretty powerful
SELECT SYSUTCDATETIME(); -- can respond to request with computation or calculation
select 'this is a string'; -- capitalization is a good idea, but not strictly enforced

-- * means all
-- [Database][Schema][Table] 

SELECT * FROM [MyDatabase].[dbo].[Artist]; -- using SELECT to specify that we want a response, and using FROM to specify where we want the data gathered from

-- gather all of the entries from the Customer table, from the dbo schema, from the MyDatabase database
SELECT * FROM [MyDatabase].[dbo].[Customer];

--gather few columns from the Customer Table?
-- Don't use the *, or use WHERE

SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer];
SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer];
SELECT FirstName + ',' + LastName AS CustomerName FROM [MyDatabase].[dbo].[Customer];
-- Concatenation and Alias to make data more legible/meaningful


-- Using WHERE to filter a response
SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer] WHERE LastName = 'Smith';
SELECT FirstName, LastName FROM [MyDatabase].[dbo].[Customer] WHERE Country = 'Canada' OR Country = 'France';

-- SQL not white space sensitive, but it looks good
SELECT FirstName + ',' + LastName AS CustomerName 
    FROM [MyDatabase].[dbo].[Customer] 
    WHERE Country = 'Canada' 
        OR Country = 'France';

-- Aggregate functions - accepts a parameter (the thing it is going to need) returns a Scalar value (just the one, not many rows or columns)
SELECT COUNT(*)
    FROM [MyDatabase].[dbo].[Customer]

SELECT * FROM [MyDatabase].[dbo].[Invoice];

SELECT SUM(Total)
    FROM [MyDatabase].[dbo].[Invoice]

SELECT CustomerId, Count(CustomerId)
    FROM [MyDatabase].[dbo].[Invoice]
    Group By CustomerId;

SELECT CustomerId, SUM(Total)
    FROM [MyDatabase].[dbo].[Invoice]
    GROUP BY CustomerId;

SELECT CustomerId, SUM(Total) AS Sum_Total
    FROM [MyDatabase].[dbo].[Invoice]
    GROUP BY CustomerId
    HAVING SUM(Total) > 40
    ORDER BY Sum_Total DESC, CustomerId;

/*
Logical order of operations:
- FROM
- WHERE
- GROUP BY
- HAVING
- SELECT
- ORDER BY
*/

-- ************** JOIN **************

-- INNER, OUTER, LEFT, RIGHT, CROSS
-- Maybe good to visualize as a Venn Diagram

-- JOIN - combining entried/records of multiple tables to gather fields from different entires into one result
-- INNER JOIN - returns the overlapping fields/results from tables
-- OUTER JOIN - 
-- LEFT JOIN
-- RIGHT JOIN
-- CROSS JOIN
-- SELF JOINT

-- KEYS
-- 

-- Every Album by Artist
-- step 1: use select * statements to find similar fields for join
SELECT * FROM [MyDatabase].[dbo].[Album];
SELECT * FROM [MyDatabase].[dbo].[Artist];

--step 2: Table.Column -> from first table -> inner join second table -> on relationship to base join
SELECT ALbum.Title, Artist.Name
    FROM [MyDatabase].[dbo].[Album] AS Album
        INNER JOIN [MyDatabase].[dbo].[Artist] AS Artist
            ON Album.ArtistId = Artist.ArtistId

-- All songs of the rock genre
SELECT * FROM [MyDatabase].[dbo].[Genre];
SELECT * FROM [MyDatabase].[dbo].[Track];

-- step 1: connect tracks to artist by rock genre
SELECT Track.Name AS 'Track', Artist.name AS 'Artist', Genre.Name AS 'Genre'
    FROM [MyDatabase].[dbo].[Track] AS Track
        INNER JOIN [MyDatabase].[dbo].[Genre] AS Genre
            ON Track.GenreId = Genre.GenreId
        INNER JOIN [MyDatabase].[dbo].[Album] AS Album
            ON Track.AlbumId = Album.AlbumId
        INNER JOIN [MyDatabase].[dbo].[Artist] AS Artist
            ON Album.ArtistId = Artist.ArtistID
    WHERE Genre.Name = 'Rock';
