# mRemoteNG PuTTY Importer

mRemoteNG PuTTY Importer is a console application designed to streamline the process of importing PuTTY sessions into mRemoteNG. It reads PuTTY session configurations from the Windows registry, checks for duplicates, and seamlessly adds new sessions to the mRemoteNG configuration file (`confCons.xml`).

## Features

- Automatically detects and reads PuTTY sessions from the Windows registry.
- Checks for existing session names in the mRemoteNG configuration file to avoid duplicates.
- Imports new sessions into mRemoteNG's configuration file with relevant details such as hostname, port, username, and password.
- Saves the updated `confCons.xml` file in place.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/jrnker/mRemoteNG_PuttyImporter.git
   ```

2. Open the solution in your preferred .NET IDE (e.g., Visual Studio).

3. Build the project to generate the executable.

4. Ensure you have mRemoteNG installed and that its configuration file (`confCons.xml`) exists in the appropriate location (e.g., `%AppData%\mRemoteNG\confCons.xml`).

## Usage by compiling the project

1. Run the console application:
   ```bash
   mRemoteNG_PuttyImporter.exe
   ```

2. The application will:
   - Check for the existence of the `confCons.xml` file.
   - Read PuTTY sessions from the Windows registry.
   - Compare session names against existing mRemoteNG entries.
   - Add new sessions to the configuration file.

3. Any sessions already present in mRemoteNG will be skipped, and a message will be displayed in the console.

4. Upon completion, the updated `confCons.xml` file will be saved in place.

## Usage by running the executable

1. Download the latest release from the [Releases]
2. Run it ;)

## Contributing

Contributions are welcome! If you encounter any issues or have ideas for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Author

Chris Jarnaker (chris@jarnaker.com)

