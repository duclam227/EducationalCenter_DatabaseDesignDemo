CREATE PROCEDURE getTotalTuition
@MAPHIEUDANKY_LOPHOC VARCHAR(50)
AS
SELECT SUM(MH.HOCPHI) ketqua
	FROM (dbo.CHITIET_DANGKYLOPHOC CT JOIN dbo.LOPHOC LH ON CT.MALOPHOC = LH.MALOP)
		JOIN dbo.MONHOC MH ON LH.MAMH = MH.MAMH
	WHERE CT.MAPHIEUDANKY_LOPHOC = @MAPHIEUDANKY_LOPHOC;

--EXECUTE getTotalTuition 'PDK05'