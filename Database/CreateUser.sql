use QLKS
go


create proc sp_CreateUser 
as
begin
	set nocount on

	declare @username char(6)
	declare @sql varchar(200)

	declare cur cursor for
		select nv.MaNV
		from NhanVien nv

	open cur

	fetch next from cur into @username
	while @@fetch_status = 0
	begin
		set @sql = 'create login ' + quotename(@username) + ' with password = ''123456'''
		exec (@sql)
		set @sql = 'use QLKS;' +  'create user ' + quotename(@username) + ' for login ' + quotename(@username)
		exec (@sql)

		fetch next from cur into @username
	end

	close cur
	deallocate cur
end

exec sp_CreateUser
