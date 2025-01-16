# Modern Appliances Inventory Management System

Welcome to the **Modern Appliances Inventory Management System**, a console-based application designed to manage appliance inventory for a retail or service business. This program allows users to check out appliances, search by brand, filter by type, and save inventory data.

---

## Features

1. **Check Out Appliance**
   - Mark an appliance as checked out if it is available.

2. **Search by Brand**
   - Quickly find all appliances from a specific brand.

3. **Filter by Appliance Type**
   - Filter appliances based on their type:
     - Refrigerators
     - Vacuums
     - Microwaves
     - Dishwashers
   - Specify additional features, such as number of doors or sound rating.

4. **Random Appliance List**
   - Generate a random selection of appliances for showcasing or testing.

5. **Save Inventory**
   - Save all changes to the inventory back to the data file (`appliances.txt`).

---

## Data Format

The inventory is stored in a file named `appliances.txt`. Each line in the file represents an appliance, with attributes separated by semicolons (`;`). Example format:

```text
10001;Samsung;5;800;White;1200.00;3;60;70
20001;Dyson;10;300;Red;599.99;Premium;24
30001;Panasonic;8;1200;Black;450.00;2.5;kitchen
40001;Bosch;4;1500;Silver;899.99;Advanced;Quiet
```

- **Item Number**: Unique identifier for the appliance.
- **Brand**: Manufacturer or brand name.
- **Quantity**: Number of units available.
- **Wattage**: Power consumption in watts.
- **Color**: Appliance color.
- **Price**: Cost of the appliance.
- **Additional Attributes**: Vary by appliance type (e.g., number of doors, sound rating).

---

## How to Use

1. **Run the Program**
   - Open the console and run the application.

2. **Follow the Menu**
   - Select an option by entering its corresponding number:
     - `1`: Check out an appliance.
     - `2`: Find appliances by brand.
     - `3`: Display appliances by type.
     - `4`: Generate a random appliance list.
     - `5`: Save changes and exit.

3. **Input Data**
   - Provide the required details based on your selected option (e.g., item number, brand name).

4. **Save Changes**
   - Choose the "Save & exit" option to persist changes.

---

## Error Handling

- **File Not Found**: If `appliances.txt` is missing, the program will display an error message and terminate.
- **Invalid Input**: Ensure that inputs are valid and within the expected range to avoid errors.

---

## Requirements

- **Platform**: .NET 5.0 or later
- **Environment**: Windows, macOS, or Linux
- **Tools**: Any IDE or text editor to run the program

---

## Known Limitations

1. **File Dependency**: The program requires `appliances.txt` in the working directory.
2. **Error Handling**: Invalid inputs (e.g., non-numeric values) may cause crashes.
3. **No Add/Delete Operations**: Appliances can only be added or removed by editing `appliances.txt` manually.

---

## Future Enhancements

- Add the ability to create and delete appliances directly within the program.
- Improve error handling for user inputs.
- Implement support for additional appliance types.
- Enhance the user interface with a graphical or web-based version.

---

## Author

Developed by the **Modern Appliances Team**:  
- Mostapha  
- Jacob  
- Noah  
