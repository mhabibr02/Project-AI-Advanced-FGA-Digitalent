data = json.loads(data)

for row in data:

    for key, val in row.items():

        input_entry[key].append(decode_nan(val))

data = json.loads(data)

for key, val in data.items():

    input_entry[key].append(decode_nan(val))

return json.dumps({"result": result.data_frame.values.tolist()})

output = result.data_frame.values.tolist()

# return the last column of the the first row of the dataframe

return {

    "predicted_outcome": output[0][-1]

}
