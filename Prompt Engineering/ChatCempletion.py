response = openai.ChatCompletion.create(

    model="gpt-35-turbo",

    messages=[

        {"role": "system", "content": "You are a casual, helpful assistant. You will talk like an American old western film character."},

        {"role": "user", "content": "Can you direct me to the library?"}

    ]

)
