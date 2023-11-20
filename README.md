# Parity and Error Checking

This project contains C# code for performing parity checks and error detection in a set of bits.

## Features

- **Check Parity:** Determine if a set of bits has even or odd parity.
- **Calculate BCC:** Calculate Block Character Check (BCC) using XOR or summing algorithm.
- **Check Error:** Verify for errors in a block of character bits and its BCC.
- **Find BCC with Parity:** Calculate BCC through various parity methods.

## Usage

1. **Check Parity:**

   ```csharp
   string bits = "1011001";
   string parity = ParityAndErrorChecking.CheckParity(bits);
   // Output: Parity: ODD/EVEN
