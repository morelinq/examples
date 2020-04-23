# Setup

Example code is written directly into Markdown documents, which requires
nothing more than a text editor. However, to develop, run and test those
examples interactively and ensure their correctness, you will need
[Try .NET][dotnet-try] installed as a global tool using:

    dotnet tool install -g dotnet-try --version 1.0.19266.1

Once installed, simply run `dotnet try` in a directory with a clone of the
repository containing this documentation.

Try .NET requires [.NET Core 3.0 SDK][netcore3] _and_ [2.1][netcore21] to be
installed prior to its installation and use.

If you have [Docker] installed, you can get Try .NET and its requirements
setup in a ready-to-run container image without affecting your local setup.
To do so, create a file named `Dockerfile` with the following content:

```Dockerfile
FROM microsoft/dotnet:3.0-sdk

ENV PATH="${PATH}:/root/.dotnet/tools"

RUN dotnet tool install -g dotnet-try --version 1.0.19266.1 \
 && curl -sSL https://dot.net/v1/dotnet-install.sh \
    | bash /dev/stdin --install-dir /usr/share/dotnet --version 2.1.503 \
 && mkdir /doc

WORKDIR /doc

ENTRYPOINT ["dotnet", "try"]
```

Next, build the image, tagging it `dotnet-try`:

    docker build -t dotnet-try .

Then whenever you wish to develop, run and test the code in the Markdown
documents, change the current working directory of your shell (`cd`) to where
you cloned the repository containing the documents and run the image using:

    docker run -ti --rm -p 5000:80 -v "$(pwd):/doc" dotnet-try

If you are using PowerShell, run instead using:

    docker run -ti --rm -p 5000:80 -v "$($PWD)/doc" dotnet-try

If you are using the Windows Command Prompt (`cmd.exe`), run instead
using:

    docker run -ti --rm -p 5000:80 -v "%cd%/doc" dotnet-try

Finally, open a browser and navigate to `http://localhost:5000/README.md`.


[dotnet-try]: https://github.com/dotnet/try
[dotnet-try-setup]: https://github.com/dotnet/try/blob/301dacfdd8af34586def0722a08452bab6393bc9/README.md#setup
[netcore21]: https://dotnet.microsoft.com/download/dotnet-core/2.1
[netcore3]: https://dotnet.microsoft.com/download/dotnet-core/3.0
[docker]: https://www.docker.com/
