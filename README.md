# Extract Assembly-Element relationship from RVT

[![Design-Automation](https://img.shields.io/badge/Design%20Automation-v3-green.svg)](http://developer.autodesk.com/)

![Windows](https://img.shields.io/badge/Plugins-Windows-lightgrey.svg)
![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-blue.svg)
[![Revit-2022](https://img.shields.io/badge/Revit-2022-lightgrey.svg)](http://autodesk.com/revit)

## Description

This addin will extract Assembly-Element relationship from the RVT file.

## Example Result in JSON

```json
{
  "id": "d98c7618-d11c-4f5d-8e92-2d3e7a3061f5",               //!<<< Random GUID
  "source": "das_assembly_group_test",                        //!<<< Revit filename without the extension
  "items": [
    {
      "id": "87920976-b490-49cd-b4ac-ad24721119ac-00121142",  //!<<< Assembly Unique Id (Forge Object External Id)
      "category": "Assembly",
      "type": "das-assembly",                                 //!<<< Assembly type name
      "name": "das-assembly [1184066]",                       //!<<< Assembly instance name
      "mebmerIds": [
        "06024a79-8b77-4a63-84fe-1310ed90b2eb-0006167d",      //!<<< Assembly member's Unique Id (Forge Object External Id)
        "06024a79-8b77-4a63-84fe-1310ed90b2eb-0006168b",
        "06024a79-8b77-4a63-84fe-1310ed90b2eb-00061697",
        "06024a79-8b77-4a63-84fe-1310ed90b2eb-000616a3"
      ]
    },
    {
      "id": "87920976-b490-49cd-b4ac-ad24721119ac-0012114d",
      "category": "Assembly",
      "type": "das-assembly",
      "name": "das-assembly [1184077]",
      "mebmerIds": [
        "87920976-b490-49cd-b4ac-ad24721119ac-00121145",
        "87920976-b490-49cd-b4ac-ad24721119ac-00121146",
        "87920976-b490-49cd-b4ac-ad24721119ac-00121147",
        "87920976-b490-49cd-b4ac-ad24721119ac-00121148"
      ]
    }
  ]
}
```

## Forge DA Setup

### Activity via [POST activities](https://forge.autodesk.com/en/docs/design-automation/v3/reference/http/activities-POST/)

```json
{
    "commandLine": [
        "$(engine.path)\\\\revitcoreconsole.exe /i \"$(args[inputFile].path)\" /al \"$(appbundles[RevitMembersExtractAddin].path)\""
    ],
    "parameters": {
        "inputFile": {
            "verb": "get",
            "description": "Input Revit File",
            "required": true,
            "localName": "$(inputFile)"
        },
        "result": {
            "zip": false,
            "verb": "put",
            "description": "Result JSON File",
            "required": true,
            "localName": "result.json"
        }
    },
    "id": "youralais.RevitMembersExtractAddinActivity+dev",
    "engine": "Autodesk.Revit+2022",
    "appbundles": [
        "youralais.RevitMembersExtractAddin+dev"
    ],
    "settings": {},
    "description": "Activity of extracting Assembly-Element relationship from RVT",
    "version": 1
}
```

### Workitem via [POST workitems](https://forge.autodesk.com/en/docs/design-automation/v3/reference/http/workitems-POST/)

```json
{
    "activityId": "youralais.RevitMembersExtractAddinActivity+dev",
    "arguments": {
      "inputFile": {
        "verb": "get",
        "url": "https://developer.api.autodesk.com/oss/v2/signedresources/...region=US"
      },
      "result": {
        "verb": "put",
        "url": "https://developer.api.autodesk.com/oss/v2/signedresources/...?region=US"
      }
    }
}
```

## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT). Please see the [LICENSE](LICENSE) file for full details.

## Written by

Eason Kang [@yiskang](https://twitter.com/yiskang), [Forge Partner Development](http://forge.autodesk.com)
