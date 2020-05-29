# Dating App API

## This is an API backend to facilitate data access between the DatingApp data store and its associated [front-end app](https://github.com/OisinFoley/DatingApp-SPA).

## Requirements

Provide an ```appsetting.json``` file with the following keys:

```
{
  "AppSettings": {
    "Token": "<ADD_KEY_HERE>"
  },
  "CloudinarySettings": {
    "CloudName": "<ADD_KEY_HERE>",
    "ApiKey": "<ADD_KEY_HERE>",
    "ApiSecret": "<ADD_KEY_HERE>"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=datingapp.db"
  }
}
```