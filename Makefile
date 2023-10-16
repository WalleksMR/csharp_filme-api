dev:
	dotnet watch run --project filmesAPI.csproj
migration_add:
	dotnet ef migrations add $(name)
migration_up:
	dotnet ef database update