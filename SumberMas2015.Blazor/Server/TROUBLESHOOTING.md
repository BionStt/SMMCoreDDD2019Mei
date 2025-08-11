# Troubleshooting Guide - Sumber Mas Enterprise API

## Common Errors and Solutions

### 1. Build Errors

#### Error: `CS0234: The type or namespace name 'ApiVersion' could not be found`
**Solution:**
```bash
# Restore packages
dotnet restore

# Clean and rebuild
dotnet clean
dotnet build
```

#### Error: `CS0234: The type or namespace name 'RateLimiter' could not be found`
**Solution:**
```bash
# Add missing package reference
dotnet add package Microsoft.AspNetCore.RateLimiting
```

### 2. Runtime Errors

#### Error: `InvalidOperationException: No service for type 'IApiVersionDescriptionProvider'`
**Solution:**
- Ensure `AddVersionedApiExplorer()` is called before `AddSwaggerGen()`
- Check Program.cs configuration order

#### Error: `InvalidOperationException: No service for type 'GlobalExceptionHandler'`
**Solution:**
- Ensure `builder.Services.AddTransient<GlobalExceptionHandler>();` is added
- Check middleware registration order

### 3. API Errors

#### Error: `404 Not Found` for API endpoints
**Solution:**
- Check URL format: `/api/v1/[controller]`
- Ensure controller inherits from `BaseApiController`
- Verify route attributes are correct

#### Error: `429 Too Many Requests`
**Solution:**
- Rate limiting is working correctly
- Wait for rate limit window to reset
- Check rate limit headers in response

### 4. CORS Errors

#### Error: `Access to fetch at '...' from origin '...' has been blocked by CORS policy`
**Solution:**
- Update CORS policy in Program.cs
- Add your frontend origin to allowed origins
- Ensure CORS middleware is before authentication

### 5. Authentication Errors

#### Error: `401 Unauthorized`
**Solution:**
- Ensure JWT token is valid
- Check token expiration
- Verify Authorization header format: `Bearer {token}`

### 6. Database Connection Errors

#### Error: `SqlException: Cannot open database`
**Solution:**
- Check connection string in appsettings.json
- Ensure SQL Server is running
- Verify database exists and is accessible

### 7. Logging Errors

#### Error: `DirectoryNotFoundException: Could not find a part of the path 'logs'`
**Solution:**
```bash
# Create logs directory
mkdir logs
```

### 8. Swagger Errors

#### Error: `Swagger UI not loading`
**Solution:**
- Access via `/api-docs` (not `/swagger`)
- Check if XML documentation file exists
- Verify Swagger configuration in Program.cs

## Debugging Steps

### 1. Enable Detailed Logging
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "Microsoft.AspNetCore": "Information"
    }
  }
}
```

### 2. Check Health Endpoint
```bash
curl http://localhost:5000/health
```

### 3. Test API Endpoints
```bash
# Test with curl
curl -X GET "http://localhost:5000/api/v1/DataKonsumen/GetNamaBidangPekerjaanAsync" \
  -H "Authorization: Bearer YOUR_TOKEN"
```

### 4. Check Logs
```bash
# View application logs
tail -f logs/sumbermas-api-*.txt
```

## Performance Issues

### 1. Slow API Responses
**Solutions:**
- Check database query performance
- Enable response caching
- Monitor rate limiting impact

### 2. Memory Issues
**Solutions:**
- Check for memory leaks in middleware
- Monitor request/response logging size
- Optimize JSON serialization

## Security Issues

### 1. Rate Limiting Too Aggressive
**Solution:**
- Adjust rate limit values in Program.cs
- Use different policies for different endpoints

### 2. CORS Too Permissive
**Solution:**
- Restrict allowed origins
- Remove `AllowAnyMethod()` and `AllowAnyHeader()`
- Use specific CORS policies

## Production Deployment Issues

### 1. HTTPS Redirect Issues
**Solution:**
- Ensure SSL certificate is valid
- Check HTTPS configuration
- Verify reverse proxy settings

### 2. Environment Variables
**Solution:**
- Set `ASPNETCORE_ENVIRONMENT=Production`
- Configure production connection strings
- Set proper logging levels

## Monitoring and Alerts

### 1. Health Check Monitoring
```bash
# Monitor health endpoint
watch -n 30 curl -s http://localhost:5000/health
```

### 2. Log Monitoring
```bash
# Monitor error logs
tail -f logs/sumbermas-api-*.txt | grep ERROR
```

### 3. Performance Monitoring
- Monitor response times
- Check rate limiting metrics
- Track API usage patterns

## Support

For additional support:
- Email: sutanto.gasali@gmail.com
- Check logs in `logs/` directory
- Review API documentation at `/api-docs`
