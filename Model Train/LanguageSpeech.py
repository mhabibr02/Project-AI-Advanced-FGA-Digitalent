result = client.analyze_conversation(

    task={

        "kind": "Conversation",

        "analysisInput": {

            "conversationItem": {

                "participantId": "1",

                "id": "1",

                "modality": "text",

                "language": "en",

                "text": query

            },

            "isLoggingEnabled": False

        },

        "parameters": {

            "projectName": cls_project,

            "deploymentName": deployment_slot,

            "verbose": True

        }

    }

)
