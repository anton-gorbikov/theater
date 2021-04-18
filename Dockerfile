FROM mcr.microsoft.com/dotnet/sdk:5.0

RUN curl -sL https://deb.nodesource.com/setup_14.x | bash - \
    && apt-get install -y nodejs \
    && curl -o- -L https://yarnpkg.com/install.sh | bash \

COPY package.json package.json
RUN yarn

COPY . .

RUN yarn build:web \
    && yarn build:api
