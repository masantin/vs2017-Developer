CREATE procedure USP_GetTracks(
@trackName nvarchar (200)
)

AS BEGIN

SELECT        dbo.Track.TrackId, dbo.Track.Name AS TrackName, dbo.Track.Composer, dbo.Album.Title, dbo.MediaType.Name AS MediaTypeName, dbo.Genre.Name AS GenreName, dbo.Track.Milliseconds, 
              dbo.Track.Bytes, dbo.Track.UnitPrice
FROM          dbo.Album INNER JOIN
              dbo.Track ON dbo.Album.AlbumId = dbo.Track.AlbumId INNER JOIN
              dbo.Genre ON dbo.Track.GenreId = dbo.Genre.GenreId INNER JOIN
              dbo.MediaType ON dbo.Track.MediaTypeId = dbo.MediaType.MediaTypeId
WHERE 

track.NAME LIKE @trackName

ORDER BY TrackName

END

EXECUTE USP_GetTracks '%volta%'
