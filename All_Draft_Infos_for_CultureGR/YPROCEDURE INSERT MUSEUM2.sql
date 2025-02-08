CREATE PROCEDURE new_museum2
    @mus_id INT,
    @mus_name NVARCHAR(150),
    @mus_desc NVARCHAR(MAX),
    @mus_address NVARCHAR(MAX),
    @mus_phone NCHAR(60),
    @category_id INT,
    @period_id INT,
    @exhibit_id INT,
    @mus_avg_rate TINYINT,
    @mus_open NVARCHAR(150),
    @mus_coordinate GEOGRAPHY
AS
BEGIN
    -- Έλεγχος αν υπάρχει ήδη το μουσείο
    IF NOT EXISTS (
        SELECT 1
			FROM MUSEUMS
        WHERE mus_name = @mus_name AND mus_address = @mus_address
    )
    BEGIN
        -- Εισαγωγή νέου μουσείου
        INSERT INTO MUSEUMS (mus_id, mus_name, mus_desc, mus_address, mus_phone, category_id, period_id, exhibit_id, mus_avg_rate, mus_open, mus_coordinate)
        VALUES (@mus_id, @mus_name, @mus_desc, @mus_address, @mus_phone, @category_id, @period_id, @exhibit_id, @mus_avg_rate, @mus_open, @mus_coordinate);

        PRINT 'A NEW MUSEUM WAS ADDED TO THE LIST.';
    END
    ELSE
    BEGIN
        PRINT 'THIS MUSEUM ALREADY EXISTS IN THE LIST.';
    END
END
GO
