az deployment group create --resource-group development `
            --template-file development-environment.json `
            --parameters "{ 'password-for-dev-jan': {'value': 'Sup3rS3cureP4ssw0rd!' } }"